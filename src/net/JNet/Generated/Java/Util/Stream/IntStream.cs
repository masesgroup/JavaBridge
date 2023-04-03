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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Stream
{
    #region IntStream
    public partial class IntStream
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#empty()"/> 
        /// </summary>
        public static Java.Util.Stream.IntStream Empty
        {
            get { return SExecute<Java.Util.Stream.IntStream>("empty"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#concat(java.util.stream.IntStream,java.util.stream.IntStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Stream.IntStream"/></param>
        /// <param name="arg1"><see cref="Java.Util.Stream.IntStream"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public static Java.Util.Stream.IntStream Concat(Java.Util.Stream.IntStream arg0, Java.Util.Stream.IntStream arg1)
        {
            return SExecute<Java.Util.Stream.IntStream>("concat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#generate(java.util.function.IntSupplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntSupplier"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public static Java.Util.Stream.IntStream Generate(Java.Util.Function.IntSupplier arg0)
        {
            return SExecute<Java.Util.Stream.IntStream>("generate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#iterate(int,java.util.function.IntPredicate,java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public static Java.Util.Stream.IntStream Iterate(int arg0, Java.Util.Function.IntPredicate arg1, Java.Util.Function.IntUnaryOperator arg2)
        {
            return SExecute<Java.Util.Stream.IntStream>("iterate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#iterate(int,java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public static Java.Util.Stream.IntStream Iterate(int arg0, Java.Util.Function.IntUnaryOperator arg1)
        {
            return SExecute<Java.Util.Stream.IntStream>("iterate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#of(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public static Java.Util.Stream.IntStream Of(params int[] arg0)
        {
            if (arg0.Length == 0) return SExecute<Java.Util.Stream.IntStream>("of"); else return SExecute<Java.Util.Stream.IntStream>("of", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#of(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public static Java.Util.Stream.IntStream Of(int arg0)
        {
            return SExecute<Java.Util.Stream.IntStream>("of", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#range(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public static Java.Util.Stream.IntStream Range(int arg0, int arg1)
        {
            return SExecute<Java.Util.Stream.IntStream>("range", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#rangeClosed(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public static Java.Util.Stream.IntStream RangeClosed(int arg0, int arg1)
        {
            return SExecute<Java.Util.Stream.IntStream>("rangeClosed", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#builder()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Stream.IntStream.Builder"/></returns>
        public static Java.Util.Stream.IntStream.Builder BuilderMethod()
        {
            return SExecute<Java.Util.Stream.IntStream.Builder>("builder");
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#asDoubleStream()"/> 
        /// </summary>
        public Java.Util.Stream.DoubleStream AsDoubleStream
        {
            get { return IExecute<Java.Util.Stream.DoubleStream>("asDoubleStream"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#asLongStream()"/> 
        /// </summary>
        public Java.Util.Stream.LongStream AsLongStream
        {
            get { return IExecute<Java.Util.Stream.LongStream>("asLongStream"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#average()"/> 
        /// </summary>
        public Java.Util.OptionalDouble Average
        {
            get { return IExecute<Java.Util.OptionalDouble>("average"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#boxed()"/> 
        /// </summary>
        public Java.Util.Stream.Stream Boxed
        {
            get { return IExecute<Java.Util.Stream.Stream>("boxed"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#count()"/> 
        /// </summary>
        public long Count
        {
            get { return IExecute<long>("count"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#distinct()"/> 
        /// </summary>
        public Java.Util.Stream.IntStream Distinct
        {
            get { return IExecute<Java.Util.Stream.IntStream>("distinct"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#findAny()"/> 
        /// </summary>
        public Java.Util.OptionalInt FindAny
        {
            get { return IExecute<Java.Util.OptionalInt>("findAny"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#findFirst()"/> 
        /// </summary>
        public Java.Util.OptionalInt FindFirst
        {
            get { return IExecute<Java.Util.OptionalInt>("findFirst"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#iterator()"/> 
        /// </summary>
        public Java.Util.Iterator Iterator
        {
            get { return IExecute<Java.Util.Iterator>("iterator"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#max()"/> 
        /// </summary>
        public Java.Util.OptionalInt Max
        {
            get { return IExecute<Java.Util.OptionalInt>("max"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#min()"/> 
        /// </summary>
        public Java.Util.OptionalInt Min
        {
            get { return IExecute<Java.Util.OptionalInt>("min"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#parallel()"/> 
        /// </summary>
        public Java.Util.Stream.BaseStream Parallel
        {
            get { return IExecute<Java.Util.Stream.BaseStream>("parallel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#sequential()"/> 
        /// </summary>
        public Java.Util.Stream.BaseStream Sequential
        {
            get { return IExecute<Java.Util.Stream.BaseStream>("sequential"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#sorted()"/> 
        /// </summary>
        public Java.Util.Stream.IntStream Sorted
        {
            get { return IExecute<Java.Util.Stream.IntStream>("sorted"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#spliterator()"/> 
        /// </summary>
        public Java.Util.Spliterator Spliterator
        {
            get { return IExecute<Java.Util.Spliterator>("spliterator"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#sum()"/> 
        /// </summary>
        public int Sum
        {
            get { return IExecute<int>("sum"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#summaryStatistics()"/> 
        /// </summary>
        public Java.Util.IntSummaryStatistics SummaryStatistics
        {
            get { return IExecute<Java.Util.IntSummaryStatistics>("summaryStatistics"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#toArray()"/> 
        /// </summary>
        public int[] ToArray
        {
            get { return IExecuteArray<int>("toArray"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#collect(java.util.function.Supplier,java.util.function.ObjIntConsumer,java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.ObjIntConsumer"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <returns><see cref="object"/></returns>
        public object Collect(Java.Util.Function.Supplier arg0, Java.Util.Function.ObjIntConsumer arg1, Java.Util.Function.BiConsumer arg2)
        {
            return IExecute("collect", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#mapToObj(java.util.function.IntFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntFunction"/></param>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream MapToObj(Java.Util.Function.IntFunction arg0)
        {
            return IExecute<Java.Util.Stream.Stream>("mapToObj", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#allMatch(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AllMatch(Java.Util.Function.IntPredicate arg0)
        {
            return IExecute<bool>("allMatch", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#anyMatch(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AnyMatch(Java.Util.Function.IntPredicate arg0)
        {
            return IExecute<bool>("anyMatch", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#noneMatch(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool NoneMatch(Java.Util.Function.IntPredicate arg0)
        {
            return IExecute<bool>("noneMatch", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#reduce(int,java.util.function.IntBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.IntBinaryOperator"/></param>
        /// <returns><see cref="int"/></returns>
        public int Reduce(int arg0, Java.Util.Function.IntBinaryOperator arg1)
        {
            return IExecute<int>("reduce", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#reduce(java.util.function.IntBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntBinaryOperator"/></param>
        /// <returns><see cref="Java.Util.OptionalInt"/></returns>
        public Java.Util.OptionalInt Reduce(Java.Util.Function.IntBinaryOperator arg0)
        {
            return IExecute<Java.Util.OptionalInt>("reduce", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#mapToDouble(java.util.function.IntToDoubleFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntToDoubleFunction"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream MapToDouble(Java.Util.Function.IntToDoubleFunction arg0)
        {
            return IExecute<Java.Util.Stream.DoubleStream>("mapToDouble", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#filter(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream Filter(Java.Util.Function.IntPredicate arg0)
        {
            return IExecute<Java.Util.Stream.IntStream>("filter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#flatMap(java.util.function.IntFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntFunction"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream FlatMap(Java.Util.Function.IntFunction arg0)
        {
            return IExecute<Java.Util.Stream.IntStream>("flatMap", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#limit(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream Limit(long arg0)
        {
            return IExecute<Java.Util.Stream.IntStream>("limit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#map(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream Map(Java.Util.Function.IntUnaryOperator arg0)
        {
            return IExecute<Java.Util.Stream.IntStream>("map", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#peek(java.util.function.IntConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntConsumer"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream Peek(Java.Util.Function.IntConsumer arg0)
        {
            return IExecute<Java.Util.Stream.IntStream>("peek", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#skip(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream Skip(long arg0)
        {
            return IExecute<Java.Util.Stream.IntStream>("skip", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#mapToLong(java.util.function.IntToLongFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntToLongFunction"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream MapToLong(Java.Util.Function.IntToLongFunction arg0)
        {
            return IExecute<Java.Util.Stream.LongStream>("mapToLong", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#forEach(java.util.function.IntConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntConsumer"/></param>
        public void ForEach(Java.Util.Function.IntConsumer arg0)
        {
            IExecute("forEach", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#forEachOrdered(java.util.function.IntConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntConsumer"/></param>
        public void ForEachOrdered(Java.Util.Function.IntConsumer arg0)
        {
            IExecute("forEachOrdered", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#dropWhile(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream DropWhile(Java.Util.Function.IntPredicate arg0)
        {
            return IExecute<Java.Util.Stream.IntStream>("dropWhile", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#takeWhile(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream TakeWhile(Java.Util.Function.IntPredicate arg0)
        {
            return IExecute<Java.Util.Stream.IntStream>("takeWhile", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}