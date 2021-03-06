﻿using EChartsOption.Component.Timeline.Style;
using EChartsOption.Style;

namespace EChartsOption.Component.Timeline
{
    public class EChartsComponentTimeline : EChartsComponent
    {
        #region 字符串属性
        private string _type = "null";
        private string _notMerge = "null";
        private string _realtime = "null";
        private string _x = "null";
        private string _y = "null";
        private string _x2 = "null";
        private string _y2 = "null";
        private string _width = "null";
        private string _height = "null";
        private string _borderWidth = "null";
        private string _borderColor = "null";
        private string _padding = "null";
        private string _controlPosition = "null";
        private string _autoPlay = "null";
        private string _loop = "null";
        private string _playInterval = "null";
        private string _symbol = "null";
        private string _symbolSize = "null";
        private string _currentIndex = "null";

        /// <summary>
        /// 模式是时间类型，时间轴间隔根据时间跨度自动计算，可选为：'number'
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///时间轴上多个option切换时是否进行merge操作
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string NotMerge
        {
            get { return _notMerge; }
            set { _notMerge = value; }
        }

        /// <summary>
        /// 拖拽或点击改变时间轴是否实时显示，在不支持Canvas的浏览器中该值自动强制置为false
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Realtime
        {
            get { return _realtime; }
            set { _realtime = value; }
        }

        /// <summary>
        /// 时间轴左上角横坐标，数值单位px，支持百分比（字符串），如'50%'(显示区域横向中心)
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// 时间轴左上角纵坐标，数值单位px，支持百分比（字符串），默认无，随y2定位，如'50%'(显示区域纵向中心)
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// 时间轴右下角横坐标，数值单位px，支持百分比（字符串），如'50%'(显示区域横向中心)
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string X2
        {
            get { return _x2; }
            set { _x2 = value; }
        }

        /// <summary>
        /// 时间轴右下角纵坐标，数值单位px，支持百分比（字符串），如'50%'(显示区域纵向中心)
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Y2
        {
            get { return _y2; }
            set { _y2 = value; }
        }

        /// <summary>
        /// 时间轴宽度，默认为总宽度 - x - x2，数值单位px，指定width后将忽略x2。见下图。 
        /// 支持百分比（字符串），如'50%'(显示区域一半的宽度)
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Width
        {
            get { return _width; }
            set { _width = value; }
        }

        /// <summary>
        /// 时间轴高度，数值单位px，支持百分比（字符串），如'50%'(显示区域一半的高度)
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Height
        {
            get { return _height; }
            set { _height = value; }
        }

        /// <summary>
        /// 边框线宽
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value; }
        }

        /// <summary>
        /// 边框颜色。
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; }
        }

        /// <summary>
        /// 内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Padding
        {
            get { return _padding; }
            set { _padding = value; }
        }

        /// <summary>
        /// 播放控制器位置，可选为：'left' | 'right' | 'none'
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string ConstrolPosition
        {
            get { return _controlPosition; }
            set { _controlPosition = value; }
        }

        /// <summary>
        /// 是否自动播放
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string AutoPlay
        {
            get { return _autoPlay; }
            set { _autoPlay = value; }
        }

        /// <summary>
        /// 是否循环播放
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Loop
        {
            get { return _loop; }
            set { _loop = value; }
        }

        /// <summary>
        /// 播放时间间隔，单位ms
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string PlayInterval
        {
            get { return _playInterval; }
            set { _playInterval = value; }
        }

        /// <summary>
        /// 轴点symbol
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }

        /// <summary>
        /// 轴点symbol大小
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string SymbolSize
        {
            get { return _symbolSize; }
            set { _symbolSize = value; }
        }

        /// <summary>
        /// 当前索引位置，对应options数组，用于指定显示特定系列
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string CurrentIndex
        {
            get { return _currentIndex; }
            set { _currentIndex = value; }
        } 
        #endregion

        #region 对象属性
        /// <summary>
        /// 时间轴轴线样式，lineStyle控制线条样式
        /// </summary>
        public LineStyle LineStyle { get; set; }

        /// <summary>
        /// 时间轴标签文本 
        /// show : 是否显示 
        /// interval : 挑选间隔，默认为'auto'，可选为：'auto'（自动隐藏显示不下的） | 0（全部显示） | {number} 
        /// rotate : 旋转角度，默认为0，不旋转，正值为逆时针，负值为顺时针，可选为：-90 ~ 90 
        /// formatter ： 间隔名称格式器：{string}（Template） | {Function} 
        /// textStyle : 文字样式
        /// </summary>
        public TimeLineLabel Label { get; set; }

        /// <summary>
        /// 时间轴当前点 
        /// symbol : 当前点symbol，默认随轴上的symbol 
        /// symbolSize : 当前点symbol大小，默认随轴上symbol大小 
        /// color : 当前点symbol颜色，默认为随当前点颜色，可指定具体颜色，如无则为'#1e90ff' 
        /// borderColor ： 当前点symbol边线颜色 
        /// borderWidth ： 当前点symbol边线宽度 
        /// </summary>
        public CheckpointStyle CheckpointStyle { get; set; }

        /// <summary>
        /// 时间轴控制器样式，可指定itemSize按钮大小，itemGap按钮间隔，normal.color正常和emphasis.color高亮颜色
        /// </summary>
        public ControlStyle ControlStyle { get; set; }

        /// <summary>
        /// 时间轴列表，同时也是轴label内容
        /// </summary>
        public string[] Data { get; set; } 
        #endregion
    }
}
