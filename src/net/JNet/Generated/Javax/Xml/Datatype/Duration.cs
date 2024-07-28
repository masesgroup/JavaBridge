/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Datatype
{
    #region Duration
    public partial class Duration
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getDays()"/> 
        /// </summary>
        public int Days
        {
            get { return IExecuteWithSignature<int>("getDays", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getHours()"/> 
        /// </summary>
        public int Hours
        {
            get { return IExecuteWithSignature<int>("getHours", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getMinutes()"/> 
        /// </summary>
        public int Minutes
        {
            get { return IExecuteWithSignature<int>("getMinutes", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getMonths()"/> 
        /// </summary>
        public int Months
        {
            get { return IExecuteWithSignature<int>("getMonths", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getSeconds()"/> 
        /// </summary>
        public int Seconds
        {
            get { return IExecuteWithSignature<int>("getSeconds", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getSign()"/> 
        /// </summary>
        public int Sign
        {
            get { return IExecuteWithSignature<int>("getSign", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getXMLSchemaType()"/> 
        /// </summary>
        public Javax.Xml.Namespace.QName XMLSchemaType
        {
            get { return IExecuteWithSignature<Javax.Xml.Namespace.QName>("getXMLSchemaType", "()Ljavax/xml/namespace/QName;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getYears()"/> 
        /// </summary>
        public int Years
        {
            get { return IExecuteWithSignature<int>("getYears", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#isSet(javax.xml.datatype.DatatypeConstants.Field)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Datatype.DatatypeConstants.Field"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSet(Javax.Xml.Datatype.DatatypeConstants.Field arg0)
        {
            return IExecuteWithSignature<bool>("isSet", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#compare(javax.xml.datatype.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Datatype.Duration"/></param>
        /// <returns><see cref="int"/></returns>
        public int Compare(Javax.Xml.Datatype.Duration arg0)
        {
            return IExecuteWithSignature<int>("compare", "(Ljavax/xml/datatype/Duration;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getField(javax.xml.datatype.DatatypeConstants.Field)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Datatype.DatatypeConstants.Field"/></param>
        /// <returns><see cref="Java.Lang.Number"/></returns>
        public Java.Lang.Number GetField(Javax.Xml.Datatype.DatatypeConstants.Field arg0)
        {
            return IExecuteWithSignature<Java.Lang.Number>("getField", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Ljava/lang/Number;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#add(javax.xml.datatype.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Datatype.Duration"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration Add(Javax.Xml.Datatype.Duration arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Datatype.Duration>("add", "(Ljavax/xml/datatype/Duration;)Ljavax/xml/datatype/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#multiply(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration Multiply(Java.Math.BigDecimal arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Datatype.Duration>("multiply", "(Ljava/math/BigDecimal;)Ljavax/xml/datatype/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration Negate()
        {
            return IExecuteWithSignature<Javax.Xml.Datatype.Duration>("negate", "()Ljavax/xml/datatype/Duration;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#normalizeWith(java.util.Calendar)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Calendar"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration NormalizeWith(Java.Util.Calendar arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Datatype.Duration>("normalizeWith", "(Ljava/util/Calendar;)Ljavax/xml/datatype/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#addTo(java.util.Calendar)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Calendar"/></param>
        public void AddTo(Java.Util.Calendar arg0)
        {
            IExecuteWithSignature("addTo", "(Ljava/util/Calendar;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#isLongerThan(javax.xml.datatype.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Datatype.Duration"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsLongerThan(Javax.Xml.Datatype.Duration arg0)
        {
            return IExecuteWithSignature<bool>("isLongerThan", "(Ljavax/xml/datatype/Duration;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#isShorterThan(javax.xml.datatype.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Datatype.Duration"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsShorterThan(Javax.Xml.Datatype.Duration arg0)
        {
            return IExecuteWithSignature<bool>("isShorterThan", "(Ljavax/xml/datatype/Duration;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#multiply(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration Multiply(int arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Datatype.Duration>("multiply", "(I)Ljavax/xml/datatype/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#subtract(javax.xml.datatype.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Datatype.Duration"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration Subtract(Javax.Xml.Datatype.Duration arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Datatype.Duration>("subtract", "(Ljavax/xml/datatype/Duration;)Ljavax/xml/datatype/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getTimeInMillis(java.util.Calendar)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Calendar"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetTimeInMillis(Java.Util.Calendar arg0)
        {
            return IExecuteWithSignature<long>("getTimeInMillis", "(Ljava/util/Calendar;)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getTimeInMillis(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetTimeInMillis(Java.Util.Date arg0)
        {
            return IExecuteWithSignature<long>("getTimeInMillis", "(Ljava/util/Date;)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#addTo(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        public void AddTo(Java.Util.Date arg0)
        {
            IExecuteWithSignature("addTo", "(Ljava/util/Date;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}