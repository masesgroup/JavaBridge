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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region Spliterator
    public partial class Spliterator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#CONCURRENT"/>
        /// </summary>
        public static int CONCURRENT { get { if (!_CONCURRENTReady) { _CONCURRENTContent = SGetField<int>(LocalBridgeClazz, "CONCURRENT"); _CONCURRENTReady = true; } return _CONCURRENTContent; } }
        private static int _CONCURRENTContent = default;
        private static bool _CONCURRENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#DISTINCT"/>
        /// </summary>
        public static int DISTINCT { get { if (!_DISTINCTReady) { _DISTINCTContent = SGetField<int>(LocalBridgeClazz, "DISTINCT"); _DISTINCTReady = true; } return _DISTINCTContent; } }
        private static int _DISTINCTContent = default;
        private static bool _DISTINCTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#IMMUTABLE"/>
        /// </summary>
        public static int IMMUTABLE { get { if (!_IMMUTABLEReady) { _IMMUTABLEContent = SGetField<int>(LocalBridgeClazz, "IMMUTABLE"); _IMMUTABLEReady = true; } return _IMMUTABLEContent; } }
        private static int _IMMUTABLEContent = default;
        private static bool _IMMUTABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#NONNULL"/>
        /// </summary>
        public static int NONNULL { get { if (!_NONNULLReady) { _NONNULLContent = SGetField<int>(LocalBridgeClazz, "NONNULL"); _NONNULLReady = true; } return _NONNULLContent; } }
        private static int _NONNULLContent = default;
        private static bool _NONNULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#ORDERED"/>
        /// </summary>
        public static int ORDERED { get { if (!_ORDEREDReady) { _ORDEREDContent = SGetField<int>(LocalBridgeClazz, "ORDERED"); _ORDEREDReady = true; } return _ORDEREDContent; } }
        private static int _ORDEREDContent = default;
        private static bool _ORDEREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#SIZED"/>
        /// </summary>
        public static int SIZED { get { if (!_SIZEDReady) { _SIZEDContent = SGetField<int>(LocalBridgeClazz, "SIZED"); _SIZEDReady = true; } return _SIZEDContent; } }
        private static int _SIZEDContent = default;
        private static bool _SIZEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#SORTED"/>
        /// </summary>
        public static int SORTED { get { if (!_SORTEDReady) { _SORTEDContent = SGetField<int>(LocalBridgeClazz, "SORTED"); _SORTEDReady = true; } return _SORTEDContent; } }
        private static int _SORTEDContent = default;
        private static bool _SORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#SUBSIZED"/>
        /// </summary>
        public static int SUBSIZED { get { if (!_SUBSIZEDReady) { _SUBSIZEDContent = SGetField<int>(LocalBridgeClazz, "SUBSIZED"); _SUBSIZEDReady = true; } return _SUBSIZEDContent; } }
        private static int _SUBSIZEDContent = default;
        private static bool _SUBSIZEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#getExactSizeIfKnown()"/> 
        /// </summary>
        public long ExactSizeIfKnown
        {
            get { return IExecuteWithSignature<long>("getExactSizeIfKnown", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#tryAdvance(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool TryAdvance(Java.Util.Function.Consumer arg0)
        {
            return IExecuteWithSignature<bool>("tryAdvance", "(Ljava/util/function/Consumer;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#characteristics()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Characteristics()
        {
            return IExecuteWithSignature<int>("characteristics", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#trySplit()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public Java.Util.Spliterator TrySplit()
        {
            return IExecuteWithSignature<Java.Util.Spliterator>("trySplit", "()Ljava/util/Spliterator;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#estimateSize()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long EstimateSize()
        {
            return IExecuteWithSignature<long>("estimateSize", "()J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#hasCharacteristics(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasCharacteristics(int arg0)
        {
            return IExecuteWithSignature<bool>("hasCharacteristics", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#forEachRemaining(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        public void ForEachRemaining(Java.Util.Function.Consumer arg0)
        {
            IExecuteWithSignature("forEachRemaining", "(Ljava/util/function/Consumer;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region OfDouble
        public partial class OfDouble
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfDouble.html#tryAdvance(java.util.function.DoubleConsumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.DoubleConsumer"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance(Java.Util.Function.DoubleConsumer arg0)
            {
                return IExecuteWithSignature<bool>("tryAdvance", "(Ljava/util/function/DoubleConsumer;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfDouble.html#tryAdvance(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance(object arg0)
            {
                return IExecuteWithSignature<bool>("tryAdvance", "(Ljava/lang/Object;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfDouble.html#tryAdvance(java.util.function.Consumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
            /// <typeparam name="Arg0objectSuperJava_Lang_Double"><see cref="Java.Lang.Double"/></typeparam>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance<Arg0objectSuperJava_Lang_Double>(Java.Util.Function.Consumer<Arg0objectSuperJava_Lang_Double> arg0) where Arg0objectSuperJava_Lang_Double: Java.Lang.Double
            {
                return IExecuteWithSignature<bool>("tryAdvance", "(Ljava/util/function/Consumer;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfDouble.html#trySplit()"/>
            /// </summary>

            /// <returns><see cref="Java.Util.Spliterator.OfPrimitive"/></returns>
            public Java.Util.Spliterator.OfPrimitive TrySplit()
            {
                return IExecuteWithSignature<Java.Util.Spliterator.OfPrimitive>("trySplit", "()Ljava/util/Spliterator$OfPrimitive;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfDouble.html#forEachRemaining(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            public void ForEachRemaining(object arg0)
            {
                IExecuteWithSignature("forEachRemaining", "(Ljava/lang/Object;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfDouble.html#forEachRemaining(java.util.function.Consumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
            /// <typeparam name="Arg0objectSuperJava_Lang_Double"><see cref="Java.Lang.Double"/></typeparam>
            public void ForEachRemaining<Arg0objectSuperJava_Lang_Double>(Java.Util.Function.Consumer<Arg0objectSuperJava_Lang_Double> arg0) where Arg0objectSuperJava_Lang_Double: Java.Lang.Double
            {
                IExecuteWithSignature("forEachRemaining", "(Ljava/util/function/Consumer;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfDouble.html#forEachRemaining(java.util.function.DoubleConsumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.DoubleConsumer"/></param>
            public void ForEachRemaining(Java.Util.Function.DoubleConsumer arg0)
            {
                IExecuteWithSignature("forEachRemaining", "(Ljava/util/function/DoubleConsumer;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OfInt
        public partial class OfInt
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfInt.html#tryAdvance(java.util.function.IntConsumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.IntConsumer"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance(Java.Util.Function.IntConsumer arg0)
            {
                return IExecuteWithSignature<bool>("tryAdvance", "(Ljava/util/function/IntConsumer;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfInt.html#tryAdvance(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance(object arg0)
            {
                return IExecuteWithSignature<bool>("tryAdvance", "(Ljava/lang/Object;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfInt.html#tryAdvance(java.util.function.Consumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
            /// <typeparam name="Arg0objectSuperJava_Lang_Integer"><see cref="Java.Lang.Integer"/></typeparam>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance<Arg0objectSuperJava_Lang_Integer>(Java.Util.Function.Consumer<Arg0objectSuperJava_Lang_Integer> arg0) where Arg0objectSuperJava_Lang_Integer: Java.Lang.Integer
            {
                return IExecuteWithSignature<bool>("tryAdvance", "(Ljava/util/function/Consumer;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfInt.html#trySplit()"/>
            /// </summary>

            /// <returns><see cref="Java.Util.Spliterator.OfPrimitive"/></returns>
            public Java.Util.Spliterator.OfPrimitive TrySplit()
            {
                return IExecuteWithSignature<Java.Util.Spliterator.OfPrimitive>("trySplit", "()Ljava/util/Spliterator$OfPrimitive;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfInt.html#forEachRemaining(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            public void ForEachRemaining(object arg0)
            {
                IExecuteWithSignature("forEachRemaining", "(Ljava/lang/Object;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfInt.html#forEachRemaining(java.util.function.Consumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
            /// <typeparam name="Arg0objectSuperJava_Lang_Integer"><see cref="Java.Lang.Integer"/></typeparam>
            public void ForEachRemaining<Arg0objectSuperJava_Lang_Integer>(Java.Util.Function.Consumer<Arg0objectSuperJava_Lang_Integer> arg0) where Arg0objectSuperJava_Lang_Integer: Java.Lang.Integer
            {
                IExecuteWithSignature("forEachRemaining", "(Ljava/util/function/Consumer;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfInt.html#forEachRemaining(java.util.function.IntConsumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.IntConsumer"/></param>
            public void ForEachRemaining(Java.Util.Function.IntConsumer arg0)
            {
                IExecuteWithSignature("forEachRemaining", "(Ljava/util/function/IntConsumer;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OfLong
        public partial class OfLong
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfLong.html#tryAdvance(java.util.function.LongConsumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.LongConsumer"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance(Java.Util.Function.LongConsumer arg0)
            {
                return IExecuteWithSignature<bool>("tryAdvance", "(Ljava/util/function/LongConsumer;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfLong.html#tryAdvance(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance(object arg0)
            {
                return IExecuteWithSignature<bool>("tryAdvance", "(Ljava/lang/Object;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfLong.html#tryAdvance(java.util.function.Consumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
            /// <typeparam name="Arg0objectSuperJava_Lang_Long"><see cref="Java.Lang.Long"/></typeparam>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance<Arg0objectSuperJava_Lang_Long>(Java.Util.Function.Consumer<Arg0objectSuperJava_Lang_Long> arg0) where Arg0objectSuperJava_Lang_Long: Java.Lang.Long
            {
                return IExecuteWithSignature<bool>("tryAdvance", "(Ljava/util/function/Consumer;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfLong.html#trySplit()"/>
            /// </summary>

            /// <returns><see cref="Java.Util.Spliterator.OfPrimitive"/></returns>
            public Java.Util.Spliterator.OfPrimitive TrySplit()
            {
                return IExecuteWithSignature<Java.Util.Spliterator.OfPrimitive>("trySplit", "()Ljava/util/Spliterator$OfPrimitive;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfLong.html#forEachRemaining(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            public void ForEachRemaining(object arg0)
            {
                IExecuteWithSignature("forEachRemaining", "(Ljava/lang/Object;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfLong.html#forEachRemaining(java.util.function.Consumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
            /// <typeparam name="Arg0objectSuperJava_Lang_Long"><see cref="Java.Lang.Long"/></typeparam>
            public void ForEachRemaining<Arg0objectSuperJava_Lang_Long>(Java.Util.Function.Consumer<Arg0objectSuperJava_Lang_Long> arg0) where Arg0objectSuperJava_Lang_Long: Java.Lang.Long
            {
                IExecuteWithSignature("forEachRemaining", "(Ljava/util/function/Consumer;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfLong.html#forEachRemaining(java.util.function.LongConsumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.LongConsumer"/></param>
            public void ForEachRemaining(Java.Util.Function.LongConsumer arg0)
            {
                IExecuteWithSignature("forEachRemaining", "(Ljava/util/function/LongConsumer;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OfPrimitive
        public partial class OfPrimitive
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfPrimitive.html#tryAdvance(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance(object arg0)
            {
                return IExecuteWithSignature<bool>("tryAdvance", "(Ljava/lang/Object;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfPrimitive.html#trySplit()"/>
            /// </summary>

            /// <returns><see cref="Java.Util.Spliterator"/></returns>
            public Java.Util.Spliterator TrySplit()
            {
                return IExecuteWithSignature<Java.Util.Spliterator>("trySplit", "()Ljava/util/Spliterator;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfPrimitive.html#forEachRemaining(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            public void ForEachRemaining(object arg0)
            {
                IExecuteWithSignature("forEachRemaining", "(Ljava/lang/Object;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OfPrimitive<T, T_CONS, T_SPLITR>
        public partial class OfPrimitive<T, T_CONS, T_SPLITR>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Util.Spliterator.OfPrimitive{T, T_CONS, T_SPLITR}"/> to <see cref="Java.Util.Spliterator.OfPrimitive"/>
            /// </summary>
            public static implicit operator Java.Util.Spliterator.OfPrimitive(Java.Util.Spliterator.OfPrimitive<T, T_CONS, T_SPLITR> t) => t.Cast<Java.Util.Spliterator.OfPrimitive>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfPrimitive.html#tryAdvance(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><typeparamref name="T_CONS"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance(T_CONS arg0)
            {
                return IExecuteWithSignature<bool>("tryAdvance", "(Ljava/lang/Object;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfPrimitive.html#trySplit()"/>
            /// </summary>

            /// <returns><see cref="Java.Util.Spliterator"/></returns>
            public Java.Util.Spliterator TrySplit()
            {
                return IExecuteWithSignature<Java.Util.Spliterator>("trySplit", "()Ljava/util/Spliterator;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfPrimitive.html#forEachRemaining(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><typeparamref name="T_CONS"/></param>
            public void ForEachRemaining(T_CONS arg0)
            {
                IExecuteWithSignature("forEachRemaining", "(Ljava/lang/Object;)V", arg0);
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

    #region ISpliterator<T>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISpliterator<T>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#getExactSizeIfKnown()"/> 
        /// </summary>
        long ExactSizeIfKnown { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#tryAdvance(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        bool TryAdvance<Arg0objectSuperT>(Java.Util.Function.Consumer<Arg0objectSuperT> arg0) where Arg0objectSuperT: T;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#characteristics()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        int Characteristics();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#trySplit()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        Java.Util.Spliterator<T> TrySplit();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#estimateSize()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        long EstimateSize();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#hasCharacteristics(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        bool HasCharacteristics(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#forEachRemaining(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        void ForEachRemaining<Arg0objectSuperT>(Java.Util.Function.Consumer<Arg0objectSuperT> arg0) where Arg0objectSuperT: T;

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Spliterator<T>
    public partial class Spliterator<T> : Java.Util.ISpliterator<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Spliterator{T}"/> to <see cref="Java.Util.Spliterator"/>
        /// </summary>
        public static implicit operator Java.Util.Spliterator(Java.Util.Spliterator<T> t) => t.Cast<Java.Util.Spliterator>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#CONCURRENT"/>
        /// </summary>
        public static int CONCURRENT { get { if (!_CONCURRENTReady) { _CONCURRENTContent = SGetField<int>(LocalBridgeClazz, "CONCURRENT"); _CONCURRENTReady = true; } return _CONCURRENTContent; } }
        private static int _CONCURRENTContent = default;
        private static bool _CONCURRENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#DISTINCT"/>
        /// </summary>
        public static int DISTINCT { get { if (!_DISTINCTReady) { _DISTINCTContent = SGetField<int>(LocalBridgeClazz, "DISTINCT"); _DISTINCTReady = true; } return _DISTINCTContent; } }
        private static int _DISTINCTContent = default;
        private static bool _DISTINCTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#IMMUTABLE"/>
        /// </summary>
        public static int IMMUTABLE { get { if (!_IMMUTABLEReady) { _IMMUTABLEContent = SGetField<int>(LocalBridgeClazz, "IMMUTABLE"); _IMMUTABLEReady = true; } return _IMMUTABLEContent; } }
        private static int _IMMUTABLEContent = default;
        private static bool _IMMUTABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#NONNULL"/>
        /// </summary>
        public static int NONNULL { get { if (!_NONNULLReady) { _NONNULLContent = SGetField<int>(LocalBridgeClazz, "NONNULL"); _NONNULLReady = true; } return _NONNULLContent; } }
        private static int _NONNULLContent = default;
        private static bool _NONNULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#ORDERED"/>
        /// </summary>
        public static int ORDERED { get { if (!_ORDEREDReady) { _ORDEREDContent = SGetField<int>(LocalBridgeClazz, "ORDERED"); _ORDEREDReady = true; } return _ORDEREDContent; } }
        private static int _ORDEREDContent = default;
        private static bool _ORDEREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#SIZED"/>
        /// </summary>
        public static int SIZED { get { if (!_SIZEDReady) { _SIZEDContent = SGetField<int>(LocalBridgeClazz, "SIZED"); _SIZEDReady = true; } return _SIZEDContent; } }
        private static int _SIZEDContent = default;
        private static bool _SIZEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#SORTED"/>
        /// </summary>
        public static int SORTED { get { if (!_SORTEDReady) { _SORTEDContent = SGetField<int>(LocalBridgeClazz, "SORTED"); _SORTEDReady = true; } return _SORTEDContent; } }
        private static int _SORTEDContent = default;
        private static bool _SORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#SUBSIZED"/>
        /// </summary>
        public static int SUBSIZED { get { if (!_SUBSIZEDReady) { _SUBSIZEDContent = SGetField<int>(LocalBridgeClazz, "SUBSIZED"); _SUBSIZEDReady = true; } return _SUBSIZEDContent; } }
        private static int _SUBSIZEDContent = default;
        private static bool _SUBSIZEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#getExactSizeIfKnown()"/> 
        /// </summary>
        public long ExactSizeIfKnown
        {
            get { return IExecuteWithSignature<long>("getExactSizeIfKnown", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#tryAdvance(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool TryAdvance<Arg0objectSuperT>(Java.Util.Function.Consumer<Arg0objectSuperT> arg0) where Arg0objectSuperT: T
        {
            return IExecuteWithSignature<bool>("tryAdvance", "(Ljava/util/function/Consumer;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#characteristics()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Characteristics()
        {
            return IExecuteWithSignature<int>("characteristics", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#trySplit()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public Java.Util.Spliterator<T> TrySplit()
        {
            return IExecuteWithSignature<Java.Util.Spliterator<T>>("trySplit", "()Ljava/util/Spliterator;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#estimateSize()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long EstimateSize()
        {
            return IExecuteWithSignature<long>("estimateSize", "()J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#hasCharacteristics(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasCharacteristics(int arg0)
        {
            return IExecuteWithSignature<bool>("hasCharacteristics", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#forEachRemaining(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        public void ForEachRemaining<Arg0objectSuperT>(Java.Util.Function.Consumer<Arg0objectSuperT> arg0) where Arg0objectSuperT: T
        {
            IExecuteWithSignature("forEachRemaining", "(Ljava/util/function/Consumer;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}