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
*  This file is generated by MASES.JNetReflector (ver. 2.2.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region RowFilter
    public partial class RowFilter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#andFilter(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter AndFilterMethod(Java.Lang.Iterable arg0)
        {
            return SExecute<Javax.Swing.RowFilter>(LocalBridgeClazz, "andFilter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#dateFilter(javax.swing.RowFilter.ComparisonType,java.util.Date,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.RowFilter.ComparisonType"/></param>
        /// <param name="arg1"><see cref="Java.Util.Date"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter DateFilterMethod(Javax.Swing.RowFilter.ComparisonType arg0, Java.Util.Date arg1, params int[] arg2)
        {
            if (arg2.Length == 0) return SExecute<Javax.Swing.RowFilter>(LocalBridgeClazz, "dateFilter", arg0, arg1); else return SExecute<Javax.Swing.RowFilter>(LocalBridgeClazz, "dateFilter", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#notFilter(javax.swing.RowFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.RowFilter"/></param>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter NotFilterMethod(Javax.Swing.RowFilter arg0)
        {
            return SExecute<Javax.Swing.RowFilter>(LocalBridgeClazz, "notFilter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#numberFilter(javax.swing.RowFilter.ComparisonType,java.lang.Number,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.RowFilter.ComparisonType"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Number"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter NumberFilterMethod(Javax.Swing.RowFilter.ComparisonType arg0, Java.Lang.Number arg1, params int[] arg2)
        {
            if (arg2.Length == 0) return SExecute<Javax.Swing.RowFilter>(LocalBridgeClazz, "numberFilter", arg0, arg1); else return SExecute<Javax.Swing.RowFilter>(LocalBridgeClazz, "numberFilter", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#orFilter(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter OrFilterMethod(Java.Lang.Iterable arg0)
        {
            return SExecute<Javax.Swing.RowFilter>(LocalBridgeClazz, "orFilter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#regexFilter(java.lang.String,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter RegexFilterMethod(string arg0, params int[] arg1)
        {
            if (arg1.Length == 0) return SExecute<Javax.Swing.RowFilter>(LocalBridgeClazz, "regexFilter", arg0); else return SExecute<Javax.Swing.RowFilter>(LocalBridgeClazz, "regexFilter", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#include(javax.swing.RowFilter.Entry)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.RowFilter.Entry"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Include(Javax.Swing.RowFilter.Entry arg0)
        {
            return IExecute<bool>("include", arg0);
        }

        #endregion

        #region Nested classes
        #region ComparisonType
        public partial class ComparisonType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.ComparisonType.html#AFTER"/>
            /// </summary>
            public static Javax.Swing.RowFilter.ComparisonType AFTER { get { return SGetField<Javax.Swing.RowFilter.ComparisonType>(LocalBridgeClazz, "AFTER"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.ComparisonType.html#BEFORE"/>
            /// </summary>
            public static Javax.Swing.RowFilter.ComparisonType BEFORE { get { return SGetField<Javax.Swing.RowFilter.ComparisonType>(LocalBridgeClazz, "BEFORE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.ComparisonType.html#EQUAL"/>
            /// </summary>
            public static Javax.Swing.RowFilter.ComparisonType EQUAL { get { return SGetField<Javax.Swing.RowFilter.ComparisonType>(LocalBridgeClazz, "EQUAL"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.ComparisonType.html#NOT_EQUAL"/>
            /// </summary>
            public static Javax.Swing.RowFilter.ComparisonType NOT_EQUAL { get { return SGetField<Javax.Swing.RowFilter.ComparisonType>(LocalBridgeClazz, "NOT_EQUAL"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.ComparisonType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Javax.Swing.RowFilter.ComparisonType"/></returns>
            public static Javax.Swing.RowFilter.ComparisonType ValueOf(string arg0)
            {
                return SExecute<Javax.Swing.RowFilter.ComparisonType>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.ComparisonType.html#values()"/>
            /// </summary>

            /// <returns><see cref="Javax.Swing.RowFilter.ComparisonType"/></returns>
            public static Javax.Swing.RowFilter.ComparisonType[] Values()
            {
                return SExecuteArray<Javax.Swing.RowFilter.ComparisonType>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Entry
        public partial class Entry
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html#getIdentifier()"/> 
            /// </summary>
            public object Identifier
            {
                get { return IExecute("getIdentifier"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html#getModel()"/> 
            /// </summary>
            public object Model
            {
                get { return IExecute("getModel"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html#getValueCount()"/> 
            /// </summary>
            public int ValueCount
            {
                get { return IExecute<int>("getValueCount"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html#getValue(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="object"/></returns>
            public object GetValue(int arg0)
            {
                return IExecute("getValue", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html#getStringValue(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="string"/></returns>
            public string GetStringValue(int arg0)
            {
                return IExecute<string>("getStringValue", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Entry<M, I>
        public partial class Entry<M, I>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.RowFilter.Entry{M, I}"/> to <see cref="Javax.Swing.RowFilter.Entry"/>
            /// </summary>
            public static implicit operator Javax.Swing.RowFilter.Entry(Javax.Swing.RowFilter.Entry<M, I> t) => t.Cast<Javax.Swing.RowFilter.Entry>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html#getIdentifier()"/> 
            /// </summary>
            public I Identifier
            {
                get { return IExecute<I>("getIdentifier"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html#getModel()"/> 
            /// </summary>
            public M Model
            {
                get { return IExecute<M>("getModel"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html#getValueCount()"/> 
            /// </summary>
            public int ValueCount
            {
                get { return IExecute<int>("getValueCount"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html#getValue(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="object"/></returns>
            public object GetValue(int arg0)
            {
                return IExecute("getValue", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html#getStringValue(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="string"/></returns>
            public string GetStringValue(int arg0)
            {
                return IExecute<string>("getStringValue", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RowFilter<M, I>
    public partial class RowFilter<M, I>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.RowFilter{M, I}"/> to <see cref="Javax.Swing.RowFilter"/>
        /// </summary>
        public static implicit operator Javax.Swing.RowFilter(Javax.Swing.RowFilter<M, I> t) => t.Cast<Javax.Swing.RowFilter>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#andFilter(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Swing_RowFilter_Arg0objectSuperM_Arg0objectSuperI_"><see cref="Javax.Swing.RowFilter{Arg0objectSuperM, Arg0objectSuperI}"/></typeparam>
        /// <typeparam name="Arg0objectSuperM"><typeparamref name="M"/></typeparam>
        /// <typeparam name="Arg0objectSuperI"><typeparamref name="I"/></typeparam>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter<M, I> AndFilterMethod<Arg0ExtendsJavax_Swing_RowFilter_Arg0objectSuperM_Arg0objectSuperI_, Arg0objectSuperM, Arg0objectSuperI>(Java.Lang.Iterable<Arg0ExtendsJavax_Swing_RowFilter_Arg0objectSuperM_Arg0objectSuperI_> arg0) where Arg0ExtendsJavax_Swing_RowFilter_Arg0objectSuperM_Arg0objectSuperI_: Javax.Swing.RowFilter<Arg0objectSuperM, Arg0objectSuperI> where Arg0objectSuperM: M where Arg0objectSuperI: I
        {
            return SExecute<Javax.Swing.RowFilter<M, I>>(LocalBridgeClazz, "andFilter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#dateFilter(javax.swing.RowFilter.ComparisonType,java.util.Date,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.RowFilter.ComparisonType"/></param>
        /// <param name="arg1"><see cref="Java.Util.Date"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter<M, I> DateFilterMethod(Javax.Swing.RowFilter.ComparisonType arg0, Java.Util.Date arg1, params int[] arg2)
        {
            if (arg2.Length == 0) return SExecute<Javax.Swing.RowFilter<M, I>>(LocalBridgeClazz, "dateFilter", arg0, arg1); else return SExecute<Javax.Swing.RowFilter<M, I>>(LocalBridgeClazz, "dateFilter", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#notFilter(javax.swing.RowFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.RowFilter"/></param>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter<M, I> NotFilterMethod(Javax.Swing.RowFilter<M, I> arg0)
        {
            return SExecute<Javax.Swing.RowFilter<M, I>>(LocalBridgeClazz, "notFilter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#numberFilter(javax.swing.RowFilter.ComparisonType,java.lang.Number,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.RowFilter.ComparisonType"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Number"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter<M, I> NumberFilterMethod(Javax.Swing.RowFilter.ComparisonType arg0, Java.Lang.Number arg1, params int[] arg2)
        {
            if (arg2.Length == 0) return SExecute<Javax.Swing.RowFilter<M, I>>(LocalBridgeClazz, "numberFilter", arg0, arg1); else return SExecute<Javax.Swing.RowFilter<M, I>>(LocalBridgeClazz, "numberFilter", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#orFilter(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Swing_RowFilter_Arg0objectSuperM_Arg0objectSuperI_"><see cref="Javax.Swing.RowFilter{Arg0objectSuperM, Arg0objectSuperI}"/></typeparam>
        /// <typeparam name="Arg0objectSuperM"><typeparamref name="M"/></typeparam>
        /// <typeparam name="Arg0objectSuperI"><typeparamref name="I"/></typeparam>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter<M, I> OrFilterMethod<Arg0ExtendsJavax_Swing_RowFilter_Arg0objectSuperM_Arg0objectSuperI_, Arg0objectSuperM, Arg0objectSuperI>(Java.Lang.Iterable<Arg0ExtendsJavax_Swing_RowFilter_Arg0objectSuperM_Arg0objectSuperI_> arg0) where Arg0ExtendsJavax_Swing_RowFilter_Arg0objectSuperM_Arg0objectSuperI_: Javax.Swing.RowFilter<Arg0objectSuperM, Arg0objectSuperI> where Arg0objectSuperM: M where Arg0objectSuperI: I
        {
            return SExecute<Javax.Swing.RowFilter<M, I>>(LocalBridgeClazz, "orFilter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#regexFilter(java.lang.String,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter<M, I> RegexFilterMethod(string arg0, params int[] arg1)
        {
            if (arg1.Length == 0) return SExecute<Javax.Swing.RowFilter<M, I>>(LocalBridgeClazz, "regexFilter", arg0); else return SExecute<Javax.Swing.RowFilter<M, I>>(LocalBridgeClazz, "regexFilter", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#include(javax.swing.RowFilter.Entry)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.RowFilter.Entry"/></param>
        /// <typeparam name="Arg0ExtendsM"><typeparamref name="M"/></typeparam>
        /// <typeparam name="Arg0ExtendsI"><typeparamref name="I"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool Include<Arg0ExtendsM, Arg0ExtendsI>(Javax.Swing.RowFilter.Entry<Arg0ExtendsM, Arg0ExtendsI> arg0) where Arg0ExtendsM: M where Arg0ExtendsI: I
        {
            return IExecute<bool>("include", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}