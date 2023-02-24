/*
*  Copyright 2023 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Css
{
    #region CSSPrimitiveValue
    public partial class CSSPrimitiveValue
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.W3c.Dom.Css.CSSPrimitiveValue"/> to <see cref="Org.W3c.Dom.Css.CSSValue"/>
        /// </summary>
        public static implicit operator Org.W3c.Dom.Css.CSSValue(Org.W3c.Dom.Css.CSSPrimitiveValue t) => t.Cast<Org.W3c.Dom.Css.CSSValue>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_ATTR"/>
        /// </summary>
        public static short CSS_ATTR => Clazz.GetField<short>("CSS_ATTR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_CM"/>
        /// </summary>
        public static short CSS_CM => Clazz.GetField<short>("CSS_CM");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_COUNTER"/>
        /// </summary>
        public static short CSS_COUNTER => Clazz.GetField<short>("CSS_COUNTER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_DEG"/>
        /// </summary>
        public static short CSS_DEG => Clazz.GetField<short>("CSS_DEG");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_DIMENSION"/>
        /// </summary>
        public static short CSS_DIMENSION => Clazz.GetField<short>("CSS_DIMENSION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_EMS"/>
        /// </summary>
        public static short CSS_EMS => Clazz.GetField<short>("CSS_EMS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_EXS"/>
        /// </summary>
        public static short CSS_EXS => Clazz.GetField<short>("CSS_EXS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_GRAD"/>
        /// </summary>
        public static short CSS_GRAD => Clazz.GetField<short>("CSS_GRAD");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_HZ"/>
        /// </summary>
        public static short CSS_HZ => Clazz.GetField<short>("CSS_HZ");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_IDENT"/>
        /// </summary>
        public static short CSS_IDENT => Clazz.GetField<short>("CSS_IDENT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_IN"/>
        /// </summary>
        public static short CSS_IN => Clazz.GetField<short>("CSS_IN");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_KHZ"/>
        /// </summary>
        public static short CSS_KHZ => Clazz.GetField<short>("CSS_KHZ");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_MM"/>
        /// </summary>
        public static short CSS_MM => Clazz.GetField<short>("CSS_MM");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_MS"/>
        /// </summary>
        public static short CSS_MS => Clazz.GetField<short>("CSS_MS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_NUMBER"/>
        /// </summary>
        public static short CSS_NUMBER => Clazz.GetField<short>("CSS_NUMBER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_PC"/>
        /// </summary>
        public static short CSS_PC => Clazz.GetField<short>("CSS_PC");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_PERCENTAGE"/>
        /// </summary>
        public static short CSS_PERCENTAGE => Clazz.GetField<short>("CSS_PERCENTAGE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_PT"/>
        /// </summary>
        public static short CSS_PT => Clazz.GetField<short>("CSS_PT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_PX"/>
        /// </summary>
        public static short CSS_PX => Clazz.GetField<short>("CSS_PX");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_RAD"/>
        /// </summary>
        public static short CSS_RAD => Clazz.GetField<short>("CSS_RAD");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_RECT"/>
        /// </summary>
        public static short CSS_RECT => Clazz.GetField<short>("CSS_RECT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_RGBCOLOR"/>
        /// </summary>
        public static short CSS_RGBCOLOR => Clazz.GetField<short>("CSS_RGBCOLOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_S"/>
        /// </summary>
        public static short CSS_S => Clazz.GetField<short>("CSS_S");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_STRING"/>
        /// </summary>
        public static short CSS_STRING => Clazz.GetField<short>("CSS_STRING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_UNKNOWN"/>
        /// </summary>
        public static short CSS_UNKNOWN => Clazz.GetField<short>("CSS_UNKNOWN");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#CSS_URI"/>
        /// </summary>
        public static short CSS_URI => Clazz.GetField<short>("CSS_URI");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#getCounterValue()"/> 
        /// </summary>
        public Org.W3c.Dom.Css.Counter CounterValue
        {
            get { return IExecute<Org.W3c.Dom.Css.Counter>("getCounterValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#getPrimitiveType()"/> 
        /// </summary>
        public short PrimitiveType
        {
            get { return IExecute<short>("getPrimitiveType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#getRectValue()"/> 
        /// </summary>
        public Org.W3c.Dom.Css.Rect RectValue
        {
            get { return IExecute<Org.W3c.Dom.Css.Rect>("getRectValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#getRGBColorValue()"/> 
        /// </summary>
        public Org.W3c.Dom.Css.RGBColor RGBColorValue
        {
            get { return IExecute<Org.W3c.Dom.Css.RGBColor>("getRGBColorValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#getStringValue()"/> 
        /// </summary>
        public string StringValue
        {
            get { return IExecute<string>("getStringValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#getFloatValue(short)"/>
        /// </summary>
        /// <param name="arg0"><see langword="short"/></param>
        /// <returns><see langword="float"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public float GetFloatValue(short arg0)
        {
            return IExecute<float>("getFloatValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#setFloatValue(short,float)"/>
        /// </summary>
        /// <param name="arg0"><see langword="short"/></param>
        /// <param name="arg1"><see langword="float"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetFloatValue(short arg0, float arg1)
        {
            IExecute("setFloatValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSPrimitiveValue.html#setStringValue(short,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="short"/></param>
        /// <param name="arg1"><see langword="string"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetStringValue(short arg0, string arg1)
        {
            IExecute("setStringValue", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}