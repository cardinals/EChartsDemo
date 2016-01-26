﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsOption.Series
{
    public class MarkPointEffect
    {
        private string _show = "false";
        private string _type = "scale";
        private string _loop = "true";
        private string _period = "15";
        private string _scaleSize = "2";
        private string _boundDistance = "10";
        private string _color = "null";
        private string _shadowColor = "null";
        private string _shadowBlur = "null";

        /// <summary>
        /// 是否开启，默认关闭 
        /// </summary>
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 特效类型，默认为'scale'（放大），可选还有'bounce'（跳动） 
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// 循环动画，默认开启
        /// </summary>
        public string Loop
        {
            get { return _loop; }
            set { _loop = value; }
        }

        /// <summary>
        /// 运动周期，无单位，值越大越慢，默认为15 
        /// </summary>
        public string Period
        {
            get { return _period; }
            set { _period = value; }
        }

        /// <summary>
        /// 放大倍数，以markPoint symbolSize为基准，type为scale时有效 
        /// </summary>
        public string ScaleSize
        {
            get { return _scaleSize; }
            set { _scaleSize = value; }
        }

        /// <summary>
        /// 跳动距离，单位为px，type为bounce时有效 
        /// </summary>
        public string BoundDistance
        {
            get { return _boundDistance; }
            set { _boundDistance = value; }
        }

        /// <summary>
        ///  炫光颜色，默认跟随markPoint itemStyle定义颜色, 
        /// </summary>
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// 光影颜色，默认跟随color 
        /// </summary>
        public string ShadowColor
        {
            get { return _shadowColor; }
            set { _shadowColor = value; }
        }

        /// <summary>
        /// 光影模糊度，默认为0 
        /// </summary>
        public string ShadowBlur
        {
            get { return _shadowBlur; }
            set { _shadowBlur = value; }
        }
    }
}
