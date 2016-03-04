/*
    *
    * Wijmo Library 5.20151.48
    * http://wijmo.com/
    *
    * Copyright(c) GrapeCity, Inc.  All rights reserved.
    * 
    * Licensed under the Wijmo Commercial License. 
    * sales@wijmo.com
    * http://wijmo.com/products/wijmo-5/license/
    *
    */
/**
* Defines the @see:RadialGauge, @see:LinearGauge, and @see:BulletGraph
* controls.
*
* Unlike many gauge controls, Wijmo gauges concentrate on the data being
* displayed, with little extraneous color and markup elements. They were
* designed to be easy to use and to read, especially on small-screen devices.
*
* Wijmo gauges are composed of @see:Range objects. Every Wijmo gauge has
* at least two ranges: the "face" and the "pointer".
*
* <ul><li>
* The "face" represents the gauge background. The "min" and "max"
* properties of the face range correspond to the "min" and "max" properties
* of the gauge control, and limit the values that the gauge can display.
* </li><li>
* The "pointer" is the range that indicates the gauge's current value. The
* "max" property of the pointer range corresponds to the "value" property
* of the gauge.
* </li></ul>
*
* In addition to these two special ranges, gauges may have any number of
* additional ranges added to their "ranges" collection. These additional
* ranges can be used for two things:
*
* <ul><li>
* By default, the extra ranges appear as part of the gauge background.
* This way you can show 'zones' within the gauge, like 'good,' 'average,'
* and 'bad' for example.
* </li><li>
* If you set the gauge's "showRanges" property to false, the additional
* ranges are not shown. Instead, they are used to automatically set the
* color of the "pointer" based on the current value.
* </li></ul>
*/
declare module wijmo.gauge {
    /**
    * Specifies which values to display as text.
    */
    enum ShowText {
        /** Do not show any text in the gauge. */
        None = 0,
        /** Show the gauge's @see:value as text. */
        Value = 1,
        /** Show the gauge's @see:min and @see:max values as text. */
        MinMax = 2,
        /** Show the gauge's @see:value, @see:min, and @see:max as text. */
        All = 3,
    }
    /**
    * Base class for the Wijmo Gauge controls (abstract).
    */
    class Gauge extends Control {
        static _SVGNS: string;
        static _ctr: number;
        private _ranges;
        private _rngElements;
        private _format;
        private _showRanges;
        private _shadow;
        private _animated;
        private _animInterval;
        private _readOnly;
        private _step;
        private _showText;
        private _filterID;
        private _rangesDirty;
        private _origin;
        public _thickness: number;
        public _initialized: boolean;
        public _animColor: string;
        public _face: Range;
        public _pointer: Range;
        public _dSvg: HTMLDivElement;
        public _svg: SVGSVGElement;
        public _gFace: SVGGElement;
        public _gRanges: SVGGElement;
        public _gPointer: SVGGElement;
        public _gCover: SVGGElement;
        public _pFace: SVGPathElement;
        public _pPointer: SVGPathElement;
        public _filter: SVGFilterElement;
        public _cValue: SVGCircleElement;
        public _tValue: SVGTextElement;
        public _tMin: SVGTextElement;
        public _tMax: SVGTextElement;
        /**
        * Gets or sets the template used to instantiate @see:Gauge controls.
        */
        static controlTemplate: string;
        /**
        * Initializes a new instance of a @see:Gauge control.
        *
        * @param element The DOM element that hosts the control, or a selector for the host element (e.g. '#theCtrl').
        * @param options The JavaScript object containing initialization data for the control.
        */
        constructor(element: any, options?: any);
        /**
        * Gets or sets the value to display on the gauge.
        */
        public value : number;
        /**
        * Gets or sets the minimum value that can be displayed on the gauge.
        */
        public min : number;
        /**
        * Gets or sets the maximum value that can be displayed on the gauge.
        */
        public max : number;
        /**
        * Gets or sets the starting point used for painting the range.
        *
        * By default, this property is set to null, which causes the value range
        * to start at the gauge's minimum value, or zero if the minimum is less
        * than zero.
        */
        public origin : number;
        /**
        * Gets or sets a value indicating whether the user can edit the value using the mouse and
        * the keyboard.
        */
        public isReadOnly : boolean;
        /**
        * Gets or sets the amount to add to or subtract from the @see:value property
        * when the user presses the arrow keys.
        */
        public step : number;
        /**
        * Gets or sets the format string to use for displaying the gauge values
        * as text.
        */
        public format : string;
        /**
        * Gets or sets the thickness of the gauge, on a scale between zero and one.
        *
        * Setting the thickness to one causes the gauge to fill as much of the
        * control area as possible. Smaller values create thinner gauges.
        */
        public thickness : number;
        /**
        * Gets the @see:Range used to represent the gauge's overall geometry
        * and appearance.
        */
        public face : Range;
        /**
        * Gets the @see:Range used to represent the gauge's current value.
        */
        public pointer : Range;
        /**
        * Gets or sets the @see:ShowText values to display as text in the gauge.
        */
        public showText : ShowText;
        /**
        * Gets or sets a value indicating whether the gauge displays the ranges contained in the @see:ranges property.
        *
        * If this property is set to false, the ranges contained in the @see:ranges property are not
        * displayed in the gauge. Instead, they are used to interpolate the color of the @see:pointer
        * range while animating value changes.
        */
        public showRanges : boolean;
        /**
        * Gets or sets a value indicating whether the gauge displays a shadow effect.
        */
        public hasShadow : boolean;
        /**
        * Gets or sets a value indicating whether the gauge animates value changes.
        */
        public isAnimated : boolean;
        /**
        * Gets the collection of ranges in this gauge.
        */
        public ranges : collections.ObservableArray;
        /**
        * Occurs when the value shown on the gauge changes.
        */
        public valueChanged: Event;
        /**
        * Raises the @see:valueChanged event.
        */
        public onValueChanged(): void;
        /**
        * Refreshes the control.
        *
        * @param fullUpdate Indicates whether to update the control layout as well as the content.
        */
        public refresh(fullUpdate?: boolean): void;
        /**
        * Gets a number that corresponds to the value of the gauge at a given point.
        *
        * For example:
        *
        * <pre>
        * // hit test a point when the user clicks on the gauge
        * gauge.hostElement.addEventListener('click', function (e) {
        *   var ht = gauge.hitTest(e.pageX, e.pageY);
        *   if (ht != null) {
        *     console.log('you clicked the gauge at value ' + ht.toString());
        *   }
        * });
        * </pre>
        *
        * @param pt The point to investigate, in window coordinates, or a MoueEvent object,
        * or the x coordinate of the point.
        * @param y The Y coordinate of the point (if the first parameter is a number).
        * @return Value of the gauge at the point, or null if the point is not on the gauge's face.
        */
        public hitTest(pt: any, y?: number): number;
        public _getFilterUrl(): string;
        public _getRangeElement(rng: Range): SVGPathElement;
        public _rangeChanged(rng: Range, e: PropertyChangedEventArgs): void;
        public _createElement(tag: string, parent: SVGElement, cls?: string): Element;
        public _centerText(e: SVGTextElement, value: number, center: Point): void;
        public _copy(key: string, value: any): boolean;
        public _getPercent: (value: any) => number;
        public _setAttribute(e: SVGElement, att: string, value: string): void;
        public _updateRange(rng: Range, value?: number): void;
        public _getPointerColor(value: number): string;
        public _keyDown(e: KeyboardEvent): void;
        public _htDown: number;
        public _mouseDown(e: MouseEvent): void;
        public _mouseMove(e: MouseEvent): void;
        public _mouseUp(e: MouseEvent): void;
        public _applyValue(value: number): void;
        public _updateRangeElement(e: SVGPathElement, rng: Range, value: number): void;
        public _updateText(): void;
        public _getValueFromPoint(pt: Point): any;
        public _fix(n: any): string;
    }
}

declare module wijmo.gauge {
    /**
    * Represents the direction in which the pointer of a @see:LinearGauge
    * increases.
    */
    enum GaugeDirection {
        /** Gauge value increases from left to right. */
        Right = 0,
        /** Gauge value increases from right to left. */
        Left = 1,
        /** Gauge value increases from bottom to top. */
        Up = 2,
        /** Gauge value increases from top to bottom. */
        Down = 3,
    }
    /**
    * The @see:LinearGauge displays a linear scale with an indicator
    * that represents a single value and optional ranges to represent
    * reference values.
    *
    * If you set the gauge's @see:isReadOnly property to false, then the
    * user will be able to edit the value by clicking on the gauge.
    *
    * @fiddle:t842jozb
    */
    class LinearGauge extends Gauge {
        private _direction;
        /**
        * Initializes a new instance of a @see:LinearGauge control.
        *
        * @param element The DOM element that will host the control, or a selector for the host element (e.g. '#theCtrl').
        * @param options JavaScript object containing initialization data for the control.
        */
        constructor(element: any, options?: any);
        /**
        * Gets or sets the direction in which the gauge is filled.
        */
        public direction : GaugeDirection;
        public _updateRangeElement(e: SVGPathElement, rng: Range, value: number): void;
        public _updateText(): void;
        public _updateSegment(path: SVGPathElement, rc: Rect): void;
        public _setText(e: SVGTextElement, value: number, rc: Rect, pos: string): void;
        public _getRangeRect(rng: Range, value?: number): Rect;
        public _getValueFromPoint(pt: Point): number;
    }
}

declare module wijmo.gauge {
    /**
    * The @see:RadialGauge displays a circular scale with an indicator
    * that represents a single value and optional ranges to represent
    * reference values.
    *
    * If you set the gauge's @see:isReadOnly property to false, then the
    * user can edit the value by clicking on the gauge.
    *
    * @fiddle:7ec2144u
    */
    class RadialGauge extends Gauge {
        private _startAngle;
        private _sweepAngle;
        private _autoScale;
        /**
        * Initializes a new instance of a @see:RadialGauge control.
        *
        * @param element The DOM element that hosts the control, or a selector for the host element (e.g. '#theCtrl').
        * @param options The JavaScript object containing initialization data for the control.
        */
        constructor(element: any, options?: any);
        /**
        * Gets or sets the starting angle for the gauge, in degrees.
        *
        * Angles are measured clockwise, starting at the 9 o'clock position.
        */
        public startAngle : number;
        /**
        * Gets or sets the sweeping angle for the gauge, in degrees.
        *
        * Angles are measured clockwise, starting at the 9 o'clock position.
        */
        public sweepAngle : number;
        /**
        * Gets or sets a value indicating whether the gauge automatically scales to fill the host element.
        */
        public autoScale : boolean;
        /**
        * Refreshes the control.
        *
        * @param fullUpdate Indicates whether to update the control layout as well as the content.
        */
        public refresh(fullUpdate?: boolean): void;
        public _updateRangeElement(e: SVGPathElement, rng: Range, value: number): void;
        public _updateText(): void;
        public _updateSegment(path: SVGPathElement, ctr: Point, rOut: number, rIn: number, start: number, sweep: number): void;
        public _getPoint(ctr: Point, angle: number, radius: number): Point;
        public _getValueFromPoint(pt: Point): number;
    }
}

declare module wijmo.gauge {
    /**
    * The @see:BulletGraph is a type of linear gauge designed specifically for use
    * in dashboards. It displays a single key measure along with a comparative
    * measure and qualitative ranges to instantly signal whether the measure is
    * good, bad, or in some other state.
    *
    * Bullet Graphs were created and popularized by dashboard design expert
    * Stephen Few. You can find more details and examples on
    * <a href="http://en.wikipedia.org/wiki/Bullet_graph">Wikipedia</a>.
    *
    * @fiddle:8uxb1vwf
    */
    class BulletGraph extends LinearGauge {
        public _rngTarget: Range;
        public _rngGood: Range;
        public _rngBad: Range;
        /**
        * Initializes a new instance of a @see:BulletGraph control.
        *
        * @param element The DOM element that hosts the control, or a selector for the host element (e.g. '#theCtrl').
        * @param options The JavaScript object containing initialization data for the control.
        */
        constructor(element: any, options?: any);
        /**
        * Gets or sets the target value for the measure.
        */
        public target : number;
        /**
        * Gets or sets a reference value considered good for the measure.
        */
        public good : number;
        /**
        * Gets or sets a reference value considered bad for the measure.
        */
        public bad : number;
        public _getRangeRect(rng: Range, value?: number): Rect;
    }
}

declare module wijmo.gauge {
    /**
    * Defines ranges to be used with @see:Gauge controls.
    *
    * @see:Range objects have @see:min and @see:max properties that
    * define the range's domain, as well as @see:color and @see:thickness
    * properties that define the range's appearance.
    *
    * Every @see:Gauge control has at least two ranges:
    * the 'face' defines the minimum and maximum values for the gauge, and
    * the 'pointer' displays the gauge's current value.
    *
    * In addition to the built-in ranges, gauges may have additional
    * ranges used to display regions of significance (for example,
    * low, medium, and high values).
    */
    class Range {
        static _ctr: number;
        private _min;
        private _max;
        private _thickness;
        private _color;
        private _name;
        /**
        * Initializes a new instance of a @see:Range.
        *
        * @param name The name of the range.
        */
        constructor(name?: string);
        /**
        * Gets or sets the minimum value for this range.
        */
        public min : number;
        /**
        * Gets or sets the maximum value for this range.
        */
        public max : number;
        /**
        * Gets or sets the color used to display this range.
        */
        public color : string;
        /**
        * Gets or sets the thickness of this range as a percentage of
        * the parent gauge's thickness.
        */
        public thickness : number;
        /**
        * Gets or sets the name of this @see:Range.
        */
        public name : string;
        /**
        * Occurs when the value of a property changes.
        */
        public propertyChanged: Event;
        /**
        * Raises the @see:propertyChanged event.
        *
        * @param e @see:PropertyChangedEventArgs that contains the property
        * name, old, and new values.
        */
        public onPropertyChanged(e: PropertyChangedEventArgs): void;
        public _setProp(name: string, value: any): void;
    }
}

