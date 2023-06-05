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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Stream
{
    #region LongStream
    public partial class LongStream
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#empty()"/> 
        /// </summary>
        public static Java.Util.Stream.LongStream Empty
        {
            get { return SExecute<Java.Util.Stream.LongStream>(LocalBridgeClazz, "empty"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#concat(java.util.stream.LongStream,java.util.stream.LongStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Stream.LongStream"/></param>
        /// <param name="arg1"><see cref="Java.Util.Stream.LongStream"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream Concat(Java.Util.Stream.LongStream arg0, Java.Util.Stream.LongStream arg1)
        {
            return SExecute<Java.Util.Stream.LongStream>(LocalBridgeClazz, "concat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#generate(java.util.function.LongSupplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongSupplier"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream Generate(Java.Util.Function.LongSupplier arg0)
        {
            return SExecute<Java.Util.Stream.LongStream>(LocalBridgeClazz, "generate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#iterate(long,java.util.function.LongPredicate,java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream Iterate(long arg0, Java.Util.Function.LongPredicate arg1, Java.Util.Function.LongUnaryOperator arg2)
        {
            return SExecute<Java.Util.Stream.LongStream>(LocalBridgeClazz, "iterate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#iterate(long,java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream Iterate(long arg0, Java.Util.Function.LongUnaryOperator arg1)
        {
            return SExecute<Java.Util.Stream.LongStream>(LocalBridgeClazz, "iterate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#of(long[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream Of(params long[] arg0)
        {
            if (arg0.Length == 0) return SExecute<Java.Util.Stream.LongStream>(LocalBridgeClazz, "of"); else return SExecute<Java.Util.Stream.LongStream>(LocalBridgeClazz, "of", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#of(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream Of(long arg0)
        {
            return SExecute<Java.Util.Stream.LongStream>(LocalBridgeClazz, "of", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#range(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream Range(long arg0, long arg1)
        {
            return SExecute<Java.Util.Stream.LongStream>(LocalBridgeClazz, "range", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#rangeClosed(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream RangeClosed(long arg0, long arg1)
        {
            return SExecute<Java.Util.Stream.LongStream>(LocalBridgeClazz, "rangeClosed", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#builder()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Stream.LongStream.Builder"/></returns>
        public static Java.Util.Stream.LongStream.Builder BuilderMethod()
        {
            return SExecute<Java.Util.Stream.LongStream.Builder>(LocalBridgeClazz, "builder");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#asDoubleStream()"/> 
        /// </summary>
        public Java.Util.Stream.DoubleStream AsDoubleStream
        {
            get { return IExecute<Java.Util.Stream.DoubleStream>("asDoubleStream"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#average()"/> 
        /// </summary>
        public Java.Util.OptionalDouble Average
        {
            get { return IExecute<Java.Util.OptionalDouble>("average"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#boxed()"/> 
        /// </summary>
        public Java.Util.Stream.Stream<long?> Boxed
        {
            get { return IExecute<Java.Util.Stream.Stream<long?>>("boxed"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#count()"/> 
        /// </summary>
        public long Count
        {
            get { return IExecute<long>("count"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#distinct()"/> 
        /// </summary>
        public Java.Util.Stream.LongStream Distinct
        {
            get { return IExecute<Java.Util.Stream.LongStream>("distinct"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#findAny()"/> 
        /// </summary>
        public Java.Util.OptionalLong FindAny
        {
            get { return IExecute<Java.Util.OptionalLong>("findAny"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#findFirst()"/> 
        /// </summary>
        public Java.Util.OptionalLong FindFirst
        {
            get { return IExecute<Java.Util.OptionalLong>("findFirst"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#iterator()"/> 
        /// </summary>
        public Java.Util.Iterator Iterator
        {
            get { return IExecute<Java.Util.Iterator>("iterator"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#max()"/> 
        /// </summary>
        public Java.Util.OptionalLong Max
        {
            get { return IExecute<Java.Util.OptionalLong>("max"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#min()"/> 
        /// </summary>
        public Java.Util.OptionalLong Min
        {
            get { return IExecute<Java.Util.OptionalLong>("min"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#parallel()"/> 
        /// </summary>
        public Java.Util.Stream.BaseStream Parallel
        {
            get { return IExecute<Java.Util.Stream.BaseStream>("parallel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#sequential()"/> 
        /// </summary>
        public Java.Util.Stream.BaseStream Sequential
        {
            get { return IExecute<Java.Util.Stream.BaseStream>("sequential"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#sorted()"/> 
        /// </summary>
        public Java.Util.Stream.LongStream Sorted
        {
            get { return IExecute<Java.Util.Stream.LongStream>("sorted"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#spliterator()"/> 
        /// </summary>
        public Java.Util.Spliterator Spliterator
        {
            get { return IExecute<Java.Util.Spliterator>("spliterator"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#sum()"/> 
        /// </summary>
        public long Sum
        {
            get { return IExecute<long>("sum"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#summaryStatistics()"/> 
        /// </summary>
        public Java.Util.LongSummaryStatistics SummaryStatistics
        {
            get { return IExecute<Java.Util.LongSummaryStatistics>("summaryStatistics"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#toArray()"/> 
        /// </summary>
        public long[] ToArray
        {
            get { return IExecuteArray<long>("toArray"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#collect(java.util.function.Supplier,java.util.function.ObjLongConsumer,java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.ObjLongConsumer"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Collect<R>(Java.Util.Function.Supplier<R> arg0, Java.Util.Function.ObjLongConsumer<R> arg1, Java.Util.Function.BiConsumer<R, R> arg2)
        {
            return IExecute<R>("collect", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#mapToObj(java.util.function.LongFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongFunction"/></param>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="Arg0ExtendsU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<U> MapToObj<U, Arg0ExtendsU>(Java.Util.Function.LongFunction<Arg0ExtendsU> arg0) where Arg0ExtendsU: U
        {
            return IExecute<Java.Util.Stream.Stream<U>>("mapToObj", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#allMatch(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AllMatch(Java.Util.Function.LongPredicate arg0)
        {
            return IExecute<bool>("allMatch", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#anyMatch(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AnyMatch(Java.Util.Function.LongPredicate arg0)
        {
            return IExecute<bool>("anyMatch", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#noneMatch(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool NoneMatch(Java.Util.Function.LongPredicate arg0)
        {
            return IExecute<bool>("noneMatch", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#reduce(java.util.function.LongBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongBinaryOperator"/></param>
        /// <returns><see cref="Java.Util.OptionalLong"/></returns>
        public Java.Util.OptionalLong Reduce(Java.Util.Function.LongBinaryOperator arg0)
        {
            return IExecute<Java.Util.OptionalLong>("reduce", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#mapToDouble(java.util.function.LongToDoubleFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongToDoubleFunction"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream MapToDouble(Java.Util.Function.LongToDoubleFunction arg0)
        {
            return IExecute<Java.Util.Stream.DoubleStream>("mapToDouble", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#mapToInt(java.util.function.LongToIntFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongToIntFunction"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream MapToInt(Java.Util.Function.LongToIntFunction arg0)
        {
            return IExecute<Java.Util.Stream.IntStream>("mapToInt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#filter(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Filter(Java.Util.Function.LongPredicate arg0)
        {
            return IExecute<Java.Util.Stream.LongStream>("filter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#flatMap(java.util.function.LongFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongFunction"/></param>
        /// <typeparam name="Arg0ExtendsJava_Util_Stream_LongStream"><see cref="Java.Util.Stream.LongStream"/></typeparam>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream FlatMap<Arg0ExtendsJava_Util_Stream_LongStream>(Java.Util.Function.LongFunction<Arg0ExtendsJava_Util_Stream_LongStream> arg0) where Arg0ExtendsJava_Util_Stream_LongStream: Java.Util.Stream.LongStream
        {
            return IExecute<Java.Util.Stream.LongStream>("flatMap", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#limit(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Limit(long arg0)
        {
            return IExecute<Java.Util.Stream.LongStream>("limit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#map(java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Map(Java.Util.Function.LongUnaryOperator arg0)
        {
            return IExecute<Java.Util.Stream.LongStream>("map", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#peek(java.util.function.LongConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongConsumer"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Peek(Java.Util.Function.LongConsumer arg0)
        {
            return IExecute<Java.Util.Stream.LongStream>("peek", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#skip(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Skip(long arg0)
        {
            return IExecute<Java.Util.Stream.LongStream>("skip", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#reduce(long,java.util.function.LongBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.LongBinaryOperator"/></param>
        /// <returns><see cref="long"/></returns>
        public long Reduce(long arg0, Java.Util.Function.LongBinaryOperator arg1)
        {
            return IExecute<long>("reduce", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#forEach(java.util.function.LongConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongConsumer"/></param>
        public void ForEach(Java.Util.Function.LongConsumer arg0)
        {
            IExecute("forEach", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#forEachOrdered(java.util.function.LongConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongConsumer"/></param>
        public void ForEachOrdered(Java.Util.Function.LongConsumer arg0)
        {
            IExecute("forEachOrdered", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#dropWhile(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream DropWhile(Java.Util.Function.LongPredicate arg0)
        {
            return IExecute<Java.Util.Stream.LongStream>("dropWhile", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html#takeWhile(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream TakeWhile(Java.Util.Function.LongPredicate arg0)
        {
            return IExecute<Java.Util.Stream.LongStream>("takeWhile", arg0);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
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
}