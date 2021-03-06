﻿using System.ComponentModel;

namespace EChartsOption.Component.DataZoom
{
    public class EChartsComponentDataZoom : EChartsComponent
    {
        private string _orient = "null";
        private string _x = "null";
        private string _y = "null";
        private string _width = "null";
        private string _height = "null";
        private string _dataBackgroundColor = "null";
        private string _fillerColor = "null";
        private string _handleColor = "null";
        private string _handleSize = "null";
        private string _xAxisIndex = "null";
        private string _yAxisIndex = "null";
        private string _start = "null";
        private string _end = "null";
        private string _showDetail = "null";
        private string _realtime = "null";
        private string _zoomLock = "null";

        /// <summary>
        /// 布局方式，默认为水平布局，可选为：'horizontal' | 'vertical'
        /// </summary>
        [DefaultValue("null")]
        public string Orient
        {
            get { return _orient; }
            set { _orient = value; }
        }

        /// <summary>
        /// 水平安放位置，默认为根据grid参数适配，纵向布局默认左侧，可指定 {number}（左上角x坐标，单位px）
        /// </summary>
        [DefaultValue("null")]
        public string X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// 垂直安放位置，默认为根据grid参数适配，纵向布局默认下方，可指定 {number}（左上角y坐标，单位px）
        /// </summary>
        [DefaultValue("null")]
        public string Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// 指定宽度，横向布局时默认为根据grid参数适配，纵向布局是默认为30，可指定 {number}（宽度，单位px）
        /// </summary>
        [DefaultValue("null")]
        public string Width
        {
            get { return _width; }
            set { _width = value; }
        }

        /// <summary>
        /// 指定高度，纵向布局时默认为根据grid参数适配，横向布局是默认为30，可指定 {number}（高度，单位px）
        /// </summary>
        [DefaultValue("null")]
        public string Height
        {
            get { return _height; }
            set { _height = value; }
        }

        /// <summary>
        /// 数据缩略背景颜色，仅以第一个系列的数据作为缩量图显示
        /// </summary>
        [DefaultValue("null")]
        public string DataBackgroundColor
        {
            get { return _dataBackgroundColor; }
            set { _dataBackgroundColor = value; }
        }

        /// <summary>
        /// 选择区域填充颜色
        /// </summary>
        [DefaultValue("null")]
        public string FillerColor
        {
            get { return _fillerColor; }
            set { _fillerColor = value; }
        }


        /// <summary>
        /// 控制手柄大小
        /// </summary>
        [DefaultValue("null")]
        public string HandleSize
        {
            get { return _handleSize; }
            set { _handleSize = value; }
        }

        /// <summary>
        /// 控制手柄颜色
        /// </summary>
        [DefaultValue("null")]
        public string HandleColor
        {
            get { return _handleColor; }
            set { _handleColor = value; }
        }

        /// <summary>
        /// 当不指定时默认控制所有横向类目，可通过数组指定多个需要控制的横向类目坐标轴Index，仅一个时可直接为数字
        /// </summary>
        [DefaultValue("null")]
        public string XAxisIndex
        {
            get { return _xAxisIndex; }
            set { _xAxisIndex = value; }
        }

        /// <summary>
        /// 当不指定时默认控制所有纵向类目，可通过数组指定多个需要控制的纵向类目坐标轴Index，仅一个时可直接为数字
        /// </summary>
        [DefaultValue("null")]
        public string YAxisIndex
        {
            get { return _yAxisIndex; }
            set { _yAxisIndex = value; }
        }

        /// <summary>
        /// 数据缩放，选择起始比例，默认为0（%），从首个数据起选择。
        /// </summary>
        [DefaultValue("null")]
        public string Start
        {
            get { return _start; }
            set { _start = value; }
        }

        /// <summary>
        /// 数据缩放，选择结束比例，默认为100（%），到最后一个数据选择结束。
        /// </summary>
        [DefaultValue("null")]
        public string End
        {
            get { return _end; }
            set { _end = value; }
        }

        /// <summary>
        /// 缩放变化是否显示定位详情。
        /// </summary>
        [DefaultValue("null")]
        public string ShowDetail
        {
            get { return _showDetail; }
            set { _showDetail = value; }
        }

        /// <summary>
        /// 缩放变化是否实时显示，在不支持Canvas的浏览器中该值自动强制置为false。
        /// </summary>
        [DefaultValue("null")]
        public string Realtime
        {
            get { return _realtime; }
            set { _realtime = value; }
        }

        /// <summary>
        /// 数据缩放锁，默认为false，当设置为true时选择区域不能伸缩，即(end - start)值保持不变，仅能做数据漫游。
        /// </summary>
        [DefaultValue("null")]
        public string ZoomLock
        {
            get { return _zoomLock; }
            set { _zoomLock = value; }
        }
    }
}
