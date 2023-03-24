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

namespace Javax.Xml.Datatype
{
    #region DatatypeFactory
    public partial class DatatypeFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#DATATYPEFACTORY_IMPLEMENTATION_CLASS"/>
        /// </summary>
        public static string DATATYPEFACTORY_IMPLEMENTATION_CLASS => Clazz.GetField<string>("DATATYPEFACTORY_IMPLEMENTATION_CLASS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#DATATYPEFACTORY_PROPERTY"/>
        /// </summary>
        public static string DATATYPEFACTORY_PROPERTY => Clazz.GetField<string>("DATATYPEFACTORY_PROPERTY");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newDefaultInstance()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Xml.Datatype.DatatypeFactory"/></returns>
        public static Javax.Xml.Datatype.DatatypeFactory NewDefaultInstance()
        {
            return SExecute<Javax.Xml.Datatype.DatatypeFactory>("newDefaultInstance");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newInstance()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Xml.Datatype.DatatypeFactory"/></returns>
        /// <exception cref="Javax.Xml.Datatype.DatatypeConfigurationException"/>
        public static Javax.Xml.Datatype.DatatypeFactory NewInstance()
        {
            return SExecute<Javax.Xml.Datatype.DatatypeFactory>("newInstance");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newInstance(java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.DatatypeFactory"/></returns>
        /// <exception cref="Javax.Xml.Datatype.DatatypeConfigurationException"/>
        public static Javax.Xml.Datatype.DatatypeFactory NewInstance(string arg0, Java.Lang.ClassLoader arg1)
        {
            return SExecute<Javax.Xml.Datatype.DatatypeFactory>("newInstance", arg0, arg1);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newDuration(boolean,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg2"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg3"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg4"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg5"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg6"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration NewDuration(bool arg0, Java.Math.BigInteger arg1, Java.Math.BigInteger arg2, Java.Math.BigInteger arg3, Java.Math.BigInteger arg4, Java.Math.BigInteger arg5, Java.Math.BigDecimal arg6)
        {
            return IExecute<Javax.Xml.Datatype.Duration>("newDuration", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newDuration(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration NewDuration(string arg0)
        {
            return IExecute<Javax.Xml.Datatype.Duration>("newDuration", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newDuration(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration NewDuration(long arg0)
        {
            return IExecute<Javax.Xml.Datatype.Duration>("newDuration", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newXMLGregorianCalendar()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Xml.Datatype.XMLGregorianCalendar"/></returns>
        public Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendar()
        {
            return IExecute<Javax.Xml.Datatype.XMLGregorianCalendar>("newXMLGregorianCalendar");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newXMLGregorianCalendar(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.XMLGregorianCalendar"/></returns>
        public Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendar(string arg0)
        {
            return IExecute<Javax.Xml.Datatype.XMLGregorianCalendar>("newXMLGregorianCalendar", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newXMLGregorianCalendar(java.math.BigInteger,int,int,int,int,int,java.math.BigDecimal,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Java.Math.BigDecimal"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.XMLGregorianCalendar"/></returns>
        public Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendar(Java.Math.BigInteger arg0, int arg1, int arg2, int arg3, int arg4, int arg5, Java.Math.BigDecimal arg6, int arg7)
        {
            return IExecute<Javax.Xml.Datatype.XMLGregorianCalendar>("newXMLGregorianCalendar", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newXMLGregorianCalendar(java.util.GregorianCalendar)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.GregorianCalendar"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.XMLGregorianCalendar"/></returns>
        public Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendar(Java.Util.GregorianCalendar arg0)
        {
            return IExecute<Javax.Xml.Datatype.XMLGregorianCalendar>("newXMLGregorianCalendar", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newDuration(boolean,int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration NewDuration(bool arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
        {
            return IExecute<Javax.Xml.Datatype.Duration>("newDuration", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newDurationDayTime(boolean,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration NewDurationDayTime(bool arg0, int arg1, int arg2, int arg3, int arg4)
        {
            return IExecute<Javax.Xml.Datatype.Duration>("newDurationDayTime", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newDurationDayTime(boolean,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg2"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg3"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg4"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration NewDurationDayTime(bool arg0, Java.Math.BigInteger arg1, Java.Math.BigInteger arg2, Java.Math.BigInteger arg3, Java.Math.BigInteger arg4)
        {
            return IExecute<Javax.Xml.Datatype.Duration>("newDurationDayTime", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newDurationDayTime(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration NewDurationDayTime(string arg0)
        {
            return IExecute<Javax.Xml.Datatype.Duration>("newDurationDayTime", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newDurationDayTime(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration NewDurationDayTime(long arg0)
        {
            return IExecute<Javax.Xml.Datatype.Duration>("newDurationDayTime", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newDurationYearMonth(boolean,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration NewDurationYearMonth(bool arg0, int arg1, int arg2)
        {
            return IExecute<Javax.Xml.Datatype.Duration>("newDurationYearMonth", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newDurationYearMonth(boolean,java.math.BigInteger,java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg2"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration NewDurationYearMonth(bool arg0, Java.Math.BigInteger arg1, Java.Math.BigInteger arg2)
        {
            return IExecute<Javax.Xml.Datatype.Duration>("newDurationYearMonth", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newDurationYearMonth(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration NewDurationYearMonth(string arg0)
        {
            return IExecute<Javax.Xml.Datatype.Duration>("newDurationYearMonth", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newDurationYearMonth(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration NewDurationYearMonth(long arg0)
        {
            return IExecute<Javax.Xml.Datatype.Duration>("newDurationYearMonth", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newXMLGregorianCalendar(int,int,int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.XMLGregorianCalendar"/></returns>
        public Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendar(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
        {
            return IExecute<Javax.Xml.Datatype.XMLGregorianCalendar>("newXMLGregorianCalendar", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newXMLGregorianCalendarDate(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.XMLGregorianCalendar"/></returns>
        public Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendarDate(int arg0, int arg1, int arg2, int arg3)
        {
            return IExecute<Javax.Xml.Datatype.XMLGregorianCalendar>("newXMLGregorianCalendarDate", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newXMLGregorianCalendarTime(int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.XMLGregorianCalendar"/></returns>
        public Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendarTime(int arg0, int arg1, int arg2, int arg3, int arg4)
        {
            return IExecute<Javax.Xml.Datatype.XMLGregorianCalendar>("newXMLGregorianCalendarTime", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newXMLGregorianCalendarTime(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.XMLGregorianCalendar"/></returns>
        public Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendarTime(int arg0, int arg1, int arg2, int arg3)
        {
            return IExecute<Javax.Xml.Datatype.XMLGregorianCalendar>("newXMLGregorianCalendarTime", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/DatatypeFactory.html#newXMLGregorianCalendarTime(int,int,int,java.math.BigDecimal,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Math.BigDecimal"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.XMLGregorianCalendar"/></returns>
        public Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendarTime(int arg0, int arg1, int arg2, Java.Math.BigDecimal arg3, int arg4)
        {
            return IExecute<Javax.Xml.Datatype.XMLGregorianCalendar>("newXMLGregorianCalendarTime", arg0, arg1, arg2, arg3, arg4);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}