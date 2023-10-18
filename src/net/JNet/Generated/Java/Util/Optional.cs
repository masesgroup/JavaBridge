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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region Optional
    public partial class Optional
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#empty()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Optional"/></returns>
        public static Java.Util.Optional Empty()
        {
            return SExecute<Java.Util.Optional>(LocalBridgeClazz, "empty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#of(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public static Java.Util.Optional Of(object arg0)
        {
            return SExecute<Java.Util.Optional>(LocalBridgeClazz, "of", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#ofNullable(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public static Java.Util.Optional OfNullable(object arg0)
        {
            return SExecute<Java.Util.Optional>(LocalBridgeClazz, "ofNullable", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#flatMap(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional FlatMap(Java.Util.Function.Function arg0)
        {
            return IExecute<Java.Util.Optional>("flatMap", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#map(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional Map(Java.Util.Function.Function arg0)
        {
            return IExecute<Java.Util.Optional>("map", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#orElseThrow(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.Throwable"/>
        public object OrElseThrow(Java.Util.Function.Supplier arg0)
        {
            return IExecute("orElseThrow", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#isEmpty()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#isPresent()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsPresent()
        {
            return IExecute<bool>("isPresent");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#filter(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional Filter(Java.Util.Function.Predicate arg0)
        {
            return IExecute<Java.Util.Optional>("filter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#or(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional Or(Java.Util.Function.Supplier arg0)
        {
            return IExecute<Java.Util.Optional>("or", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#stream()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream Stream()
        {
            return IExecute<Java.Util.Stream.Stream>("stream");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#get()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Get()
        {
            return IExecute("get");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#orElse(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object OrElse(object arg0)
        {
            return IExecute("orElse", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#orElseGet(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <returns><see cref="object"/></returns>
        public object OrElseGet(Java.Util.Function.Supplier arg0)
        {
            return IExecute("orElseGet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#orElseThrow()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object OrElseThrow()
        {
            return IExecute("orElseThrow");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#ifPresent(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        public void IfPresent(Java.Util.Function.Consumer arg0)
        {
            IExecute("ifPresent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#ifPresentOrElse(java.util.function.Consumer,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        public void IfPresentOrElse(Java.Util.Function.Consumer arg0, Java.Lang.Runnable arg1)
        {
            IExecute("ifPresentOrElse", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Optional<T>
    public partial class Optional<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Optional{T}"/> to <see cref="Java.Util.Optional"/>
        /// </summary>
        public static implicit operator Java.Util.Optional(Java.Util.Optional<T> t) => t.Cast<Java.Util.Optional>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#empty()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Optional"/></returns>
        public static Java.Util.Optional<T> Empty()
        {
            return SExecute<Java.Util.Optional<T>>(LocalBridgeClazz, "empty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#of(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public static Java.Util.Optional<T> Of(T arg0)
        {
            return SExecute<Java.Util.Optional<T>>(LocalBridgeClazz, "of", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#ofNullable(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public static Java.Util.Optional<T> OfNullable(T arg0)
        {
            return SExecute<Java.Util.Optional<T>>(LocalBridgeClazz, "ofNullable", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#flatMap(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0ExtendsJava_Util_Optional_Arg0ExtendsU_"><see cref="Java.Util.Optional{Arg0ExtendsU}"/></typeparam>
        /// <typeparam name="Arg0ExtendsU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<U> FlatMap<U, Arg0objectSuperT, Arg0ExtendsJava_Util_Optional_Arg0ExtendsU_, Arg0ExtendsU>(Java.Util.Function.Function<Arg0objectSuperT, Arg0ExtendsJava_Util_Optional_Arg0ExtendsU_> arg0) where Arg0objectSuperT: T where Arg0ExtendsJava_Util_Optional_Arg0ExtendsU_: Java.Util.Optional<Arg0ExtendsU> where Arg0ExtendsU: U
        {
            return IExecute<Java.Util.Optional<U>>("flatMap", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#map(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0ExtendsU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<U> Map<U, Arg0objectSuperT, Arg0ExtendsU>(Java.Util.Function.Function<Arg0objectSuperT, Arg0ExtendsU> arg0) where Arg0objectSuperT: T where Arg0ExtendsU: U
        {
            return IExecute<Java.Util.Optional<U>>("map", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#orElseThrow(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <typeparam name="Arg0ExtendsX"><typeparamref name="X"/></typeparam>
        /// <typeparam name="X"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Lang.Throwable"/>
        public T OrElseThrow<Arg0ExtendsX, X>(Java.Util.Function.Supplier<Arg0ExtendsX> arg0) where Arg0ExtendsX: X
        {
            return IExecute<T>("orElseThrow", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#isEmpty()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#isPresent()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsPresent()
        {
            return IExecute<bool>("isPresent");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#filter(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<T> Filter<Arg0objectSuperT>(Java.Util.Function.Predicate<Arg0objectSuperT> arg0) where Arg0objectSuperT: T
        {
            return IExecute<Java.Util.Optional<T>>("filter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#or(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <typeparam name="Arg0ExtendsJava_Util_Optional_Arg0ExtendsT_"><see cref="Java.Util.Optional{Arg0ExtendsT}"/></typeparam>
        /// <typeparam name="Arg0ExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<T> Or<Arg0ExtendsJava_Util_Optional_Arg0ExtendsT_, Arg0ExtendsT>(Java.Util.Function.Supplier<Arg0ExtendsJava_Util_Optional_Arg0ExtendsT_> arg0) where Arg0ExtendsJava_Util_Optional_Arg0ExtendsT_: Java.Util.Optional<Arg0ExtendsT> where Arg0ExtendsT: T
        {
            return IExecute<Java.Util.Optional<T>>("or", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#stream()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<T> Stream()
        {
            return IExecute<Java.Util.Stream.Stream<T>>("stream");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#get()"/>
        /// </summary>

        /// <returns><typeparamref name="T"/></returns>
        public T Get()
        {
            return IExecute<T>("get");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#orElse(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T OrElse(T arg0)
        {
            return IExecute<T>("orElse", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#orElseGet(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <typeparam name="Arg0ExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T OrElseGet<Arg0ExtendsT>(Java.Util.Function.Supplier<Arg0ExtendsT> arg0) where Arg0ExtendsT: T
        {
            return IExecute<T>("orElseGet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#orElseThrow()"/>
        /// </summary>

        /// <returns><typeparamref name="T"/></returns>
        public T OrElseThrow()
        {
            return IExecute<T>("orElseThrow");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#ifPresent(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        public void IfPresent<Arg0objectSuperT>(Java.Util.Function.Consumer<Arg0objectSuperT> arg0) where Arg0objectSuperT: T
        {
            IExecute("ifPresent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#ifPresentOrElse(java.util.function.Consumer,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        public void IfPresentOrElse<Arg0objectSuperT>(Java.Util.Function.Consumer<Arg0objectSuperT> arg0, Java.Lang.Runnable arg1) where Arg0objectSuperT: T
        {
            IExecute("ifPresentOrElse", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}