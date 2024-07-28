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

namespace Javax.Management
{
    #region Query
    public partial class Query
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#DIV"/>
        /// </summary>
        public static int DIV { get { if (!_DIVReady) { _DIVContent = SGetField<int>(LocalBridgeClazz, "DIV"); _DIVReady = true; } return _DIVContent; } }
        private static int _DIVContent = default;
        private static bool _DIVReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#EQ"/>
        /// </summary>
        public static int EQ { get { if (!_EQReady) { _EQContent = SGetField<int>(LocalBridgeClazz, "EQ"); _EQReady = true; } return _EQContent; } }
        private static int _EQContent = default;
        private static bool _EQReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#GE"/>
        /// </summary>
        public static int GE { get { if (!_GEReady) { _GEContent = SGetField<int>(LocalBridgeClazz, "GE"); _GEReady = true; } return _GEContent; } }
        private static int _GEContent = default;
        private static bool _GEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#GT"/>
        /// </summary>
        public static int GT { get { if (!_GTReady) { _GTContent = SGetField<int>(LocalBridgeClazz, "GT"); _GTReady = true; } return _GTContent; } }
        private static int _GTContent = default;
        private static bool _GTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#LE"/>
        /// </summary>
        public static int LE { get { if (!_LEReady) { _LEContent = SGetField<int>(LocalBridgeClazz, "LE"); _LEReady = true; } return _LEContent; } }
        private static int _LEContent = default;
        private static bool _LEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#LT"/>
        /// </summary>
        public static int LT { get { if (!_LTReady) { _LTContent = SGetField<int>(LocalBridgeClazz, "LT"); _LTReady = true; } return _LTContent; } }
        private static int _LTContent = default;
        private static bool _LTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#MINUS"/>
        /// </summary>
        public static int MINUS { get { if (!_MINUSReady) { _MINUSContent = SGetField<int>(LocalBridgeClazz, "MINUS"); _MINUSReady = true; } return _MINUSContent; } }
        private static int _MINUSContent = default;
        private static bool _MINUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#PLUS"/>
        /// </summary>
        public static int PLUS { get { if (!_PLUSReady) { _PLUSContent = SGetField<int>(LocalBridgeClazz, "PLUS"); _PLUSReady = true; } return _PLUSContent; } }
        private static int _PLUSContent = default;
        private static bool _PLUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#TIMES"/>
        /// </summary>
        public static int TIMES { get { if (!_TIMESReady) { _TIMESContent = SGetField<int>(LocalBridgeClazz, "TIMES"); _TIMESReady = true; } return _TIMESContent; } }
        private static int _TIMESContent = default;
        private static bool _TIMESReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#attr(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.AttributeValueExp"/></returns>
        public static Javax.Management.AttributeValueExp Attr(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Javax.Management.AttributeValueExp>(LocalBridgeClazz, "attr", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#attr(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.AttributeValueExp"/></returns>
        public static Javax.Management.AttributeValueExp Attr(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Management.AttributeValueExp>(LocalBridgeClazz, "attr", "(Ljava/lang/String;)Ljavax/management/AttributeValueExp;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#classattr()"/>
        /// </summary>
        /// <returns><see cref="Javax.Management.AttributeValueExp"/></returns>
        public static Javax.Management.AttributeValueExp Classattr()
        {
            return SExecute<Javax.Management.AttributeValueExp>(LocalBridgeClazz, "classattr");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#and(javax.management.QueryExp,javax.management.QueryExp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.QueryExp"/></param>
        /// <param name="arg1"><see cref="Javax.Management.QueryExp"/></param>
        /// <returns><see cref="Javax.Management.QueryExp"/></returns>
        public static Javax.Management.QueryExp And(Javax.Management.QueryExp arg0, Javax.Management.QueryExp arg1)
        {
            return SExecute<Javax.Management.QueryExp>(LocalBridgeClazz, "and", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#anySubString(javax.management.AttributeValueExp,javax.management.StringValueExp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.AttributeValueExp"/></param>
        /// <param name="arg1"><see cref="Javax.Management.StringValueExp"/></param>
        /// <returns><see cref="Javax.Management.QueryExp"/></returns>
        public static Javax.Management.QueryExp AnySubString(Javax.Management.AttributeValueExp arg0, Javax.Management.StringValueExp arg1)
        {
            return SExecute<Javax.Management.QueryExp>(LocalBridgeClazz, "anySubString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#between(javax.management.ValueExp,javax.management.ValueExp,javax.management.ValueExp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ValueExp"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ValueExp"/></param>
        /// <param name="arg2"><see cref="Javax.Management.ValueExp"/></param>
        /// <returns><see cref="Javax.Management.QueryExp"/></returns>
        public static Javax.Management.QueryExp Between(Javax.Management.ValueExp arg0, Javax.Management.ValueExp arg1, Javax.Management.ValueExp arg2)
        {
            return SExecute<Javax.Management.QueryExp>(LocalBridgeClazz, "between", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#eq(javax.management.ValueExp,javax.management.ValueExp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ValueExp"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ValueExp"/></param>
        /// <returns><see cref="Javax.Management.QueryExp"/></returns>
        public static Javax.Management.QueryExp Eq(Javax.Management.ValueExp arg0, Javax.Management.ValueExp arg1)
        {
            return SExecute<Javax.Management.QueryExp>(LocalBridgeClazz, "eq", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#finalSubString(javax.management.AttributeValueExp,javax.management.StringValueExp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.AttributeValueExp"/></param>
        /// <param name="arg1"><see cref="Javax.Management.StringValueExp"/></param>
        /// <returns><see cref="Javax.Management.QueryExp"/></returns>
        public static Javax.Management.QueryExp FinalSubString(Javax.Management.AttributeValueExp arg0, Javax.Management.StringValueExp arg1)
        {
            return SExecute<Javax.Management.QueryExp>(LocalBridgeClazz, "finalSubString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#geq(javax.management.ValueExp,javax.management.ValueExp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ValueExp"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ValueExp"/></param>
        /// <returns><see cref="Javax.Management.QueryExp"/></returns>
        public static Javax.Management.QueryExp Geq(Javax.Management.ValueExp arg0, Javax.Management.ValueExp arg1)
        {
            return SExecute<Javax.Management.QueryExp>(LocalBridgeClazz, "geq", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#gt(javax.management.ValueExp,javax.management.ValueExp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ValueExp"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ValueExp"/></param>
        /// <returns><see cref="Javax.Management.QueryExp"/></returns>
        public static Javax.Management.QueryExp Gt(Javax.Management.ValueExp arg0, Javax.Management.ValueExp arg1)
        {
            return SExecute<Javax.Management.QueryExp>(LocalBridgeClazz, "gt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#in(javax.management.ValueExp,javax.management.ValueExp[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ValueExp"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ValueExp"/></param>
        /// <returns><see cref="Javax.Management.QueryExp"/></returns>
        public static Javax.Management.QueryExp In(Javax.Management.ValueExp arg0, Javax.Management.ValueExp[] arg1)
        {
            return SExecute<Javax.Management.QueryExp>(LocalBridgeClazz, "in", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#initialSubString(javax.management.AttributeValueExp,javax.management.StringValueExp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.AttributeValueExp"/></param>
        /// <param name="arg1"><see cref="Javax.Management.StringValueExp"/></param>
        /// <returns><see cref="Javax.Management.QueryExp"/></returns>
        public static Javax.Management.QueryExp InitialSubString(Javax.Management.AttributeValueExp arg0, Javax.Management.StringValueExp arg1)
        {
            return SExecute<Javax.Management.QueryExp>(LocalBridgeClazz, "initialSubString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#isInstanceOf(javax.management.StringValueExp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.StringValueExp"/></param>
        /// <returns><see cref="Javax.Management.QueryExp"/></returns>
        public static Javax.Management.QueryExp IsInstanceOf(Javax.Management.StringValueExp arg0)
        {
            return SExecuteWithSignature<Javax.Management.QueryExp>(LocalBridgeClazz, "isInstanceOf", "(Ljavax/management/StringValueExp;)Ljavax/management/QueryExp;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#leq(javax.management.ValueExp,javax.management.ValueExp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ValueExp"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ValueExp"/></param>
        /// <returns><see cref="Javax.Management.QueryExp"/></returns>
        public static Javax.Management.QueryExp Leq(Javax.Management.ValueExp arg0, Javax.Management.ValueExp arg1)
        {
            return SExecute<Javax.Management.QueryExp>(LocalBridgeClazz, "leq", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#lt(javax.management.ValueExp,javax.management.ValueExp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ValueExp"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ValueExp"/></param>
        /// <returns><see cref="Javax.Management.QueryExp"/></returns>
        public static Javax.Management.QueryExp Lt(Javax.Management.ValueExp arg0, Javax.Management.ValueExp arg1)
        {
            return SExecute<Javax.Management.QueryExp>(LocalBridgeClazz, "lt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#match(javax.management.AttributeValueExp,javax.management.StringValueExp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.AttributeValueExp"/></param>
        /// <param name="arg1"><see cref="Javax.Management.StringValueExp"/></param>
        /// <returns><see cref="Javax.Management.QueryExp"/></returns>
        public static Javax.Management.QueryExp Match(Javax.Management.AttributeValueExp arg0, Javax.Management.StringValueExp arg1)
        {
            return SExecute<Javax.Management.QueryExp>(LocalBridgeClazz, "match", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#not(javax.management.QueryExp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.QueryExp"/></param>
        /// <returns><see cref="Javax.Management.QueryExp"/></returns>
        public static Javax.Management.QueryExp Not(Javax.Management.QueryExp arg0)
        {
            return SExecuteWithSignature<Javax.Management.QueryExp>(LocalBridgeClazz, "not", "(Ljavax/management/QueryExp;)Ljavax/management/QueryExp;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#or(javax.management.QueryExp,javax.management.QueryExp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.QueryExp"/></param>
        /// <param name="arg1"><see cref="Javax.Management.QueryExp"/></param>
        /// <returns><see cref="Javax.Management.QueryExp"/></returns>
        public static Javax.Management.QueryExp Or(Javax.Management.QueryExp arg0, Javax.Management.QueryExp arg1)
        {
            return SExecute<Javax.Management.QueryExp>(LocalBridgeClazz, "or", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#value(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.StringValueExp"/></returns>
        public static Javax.Management.StringValueExp Value(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Management.StringValueExp>(LocalBridgeClazz, "value", "(Ljava/lang/String;)Ljavax/management/StringValueExp;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#div(javax.management.ValueExp,javax.management.ValueExp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ValueExp"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ValueExp"/></param>
        /// <returns><see cref="Javax.Management.ValueExp"/></returns>
        public static Javax.Management.ValueExp Div(Javax.Management.ValueExp arg0, Javax.Management.ValueExp arg1)
        {
            return SExecute<Javax.Management.ValueExp>(LocalBridgeClazz, "div", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#minus(javax.management.ValueExp,javax.management.ValueExp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ValueExp"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ValueExp"/></param>
        /// <returns><see cref="Javax.Management.ValueExp"/></returns>
        public static Javax.Management.ValueExp Minus(Javax.Management.ValueExp arg0, Javax.Management.ValueExp arg1)
        {
            return SExecute<Javax.Management.ValueExp>(LocalBridgeClazz, "minus", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#plus(javax.management.ValueExp,javax.management.ValueExp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ValueExp"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ValueExp"/></param>
        /// <returns><see cref="Javax.Management.ValueExp"/></returns>
        public static Javax.Management.ValueExp Plus(Javax.Management.ValueExp arg0, Javax.Management.ValueExp arg1)
        {
            return SExecute<Javax.Management.ValueExp>(LocalBridgeClazz, "plus", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#times(javax.management.ValueExp,javax.management.ValueExp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ValueExp"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ValueExp"/></param>
        /// <returns><see cref="Javax.Management.ValueExp"/></returns>
        public static Javax.Management.ValueExp Times(Javax.Management.ValueExp arg0, Javax.Management.ValueExp arg1)
        {
            return SExecute<Javax.Management.ValueExp>(LocalBridgeClazz, "times", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#value(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Javax.Management.ValueExp"/></returns>
        public static Javax.Management.ValueExp Value(bool arg0)
        {
            return SExecuteWithSignature<Javax.Management.ValueExp>(LocalBridgeClazz, "value", "(Z)Ljavax/management/ValueExp;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#value(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Javax.Management.ValueExp"/></returns>
        public static Javax.Management.ValueExp Value(double arg0)
        {
            return SExecuteWithSignature<Javax.Management.ValueExp>(LocalBridgeClazz, "value", "(D)Ljavax/management/ValueExp;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#value(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Javax.Management.ValueExp"/></returns>
        public static Javax.Management.ValueExp Value(float arg0)
        {
            return SExecuteWithSignature<Javax.Management.ValueExp>(LocalBridgeClazz, "value", "(F)Ljavax/management/ValueExp;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#value(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Management.ValueExp"/></returns>
        public static Javax.Management.ValueExp Value(int arg0)
        {
            return SExecuteWithSignature<Javax.Management.ValueExp>(LocalBridgeClazz, "value", "(I)Ljavax/management/ValueExp;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#value(java.lang.Number)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Number"/></param>
        /// <returns><see cref="Javax.Management.ValueExp"/></returns>
        public static Javax.Management.ValueExp Value(Java.Lang.Number arg0)
        {
            return SExecuteWithSignature<Javax.Management.ValueExp>(LocalBridgeClazz, "value", "(Ljava/lang/Number;)Ljavax/management/ValueExp;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/Query.html#value(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Javax.Management.ValueExp"/></returns>
        public static Javax.Management.ValueExp Value(long arg0)
        {
            return SExecuteWithSignature<Javax.Management.ValueExp>(LocalBridgeClazz, "value", "(J)Ljavax/management/ValueExp;", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}