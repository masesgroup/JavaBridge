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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio
{
    #region FloatBuffer definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/FloatBuffer.html"/>
    /// </summary>
    public partial class FloatBuffer : Java.Nio.Buffer
    {
        const string _bridgeClassName = "java.nio.FloatBuffer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("FloatBuffer class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public FloatBuffer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("FloatBuffer class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public FloatBuffer(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region FloatBuffer
    public partial class FloatBuffer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.FloatBuffer"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Nio.FloatBuffer t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/FloatBuffer.html#allocate(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.FloatBuffer"/></returns>
        public static Java.Nio.FloatBuffer Allocate(int arg0)
        {
            return SExecuteWithSignature<Java.Nio.FloatBuffer>(LocalBridgeClazz, "allocate", "(I)Ljava/nio/FloatBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/FloatBuffer.html#wrap(float[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.FloatBuffer"/></returns>
        public static Java.Nio.FloatBuffer Wrap(float[] arg0, int arg1, int arg2)
        {
            return SExecute<Java.Nio.FloatBuffer>(LocalBridgeClazz, "wrap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/FloatBuffer.html#wrap(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Java.Nio.FloatBuffer"/></returns>
        public static Java.Nio.FloatBuffer Wrap(float[] arg0)
        {
            return SExecuteWithSignature<Java.Nio.FloatBuffer>(LocalBridgeClazz, "wrap", "([F)Ljava/nio/FloatBuffer;", new object[] { arg0 });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/FloatBuffer.html#get()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float Get()
        {
            return IExecuteWithSignature<float>("get", "()F");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/FloatBuffer.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float Get(int arg0)
        {
            return IExecuteWithSignature<float>("get", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/FloatBuffer.html#order()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.ByteOrder"/></returns>
        public Java.Nio.ByteOrder Order()
        {
            return IExecuteWithSignature<Java.Nio.ByteOrder>("order", "()Ljava/nio/ByteOrder;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/FloatBuffer.html#asReadOnlyBuffer()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.FloatBuffer"/></returns>
        public Java.Nio.FloatBuffer AsReadOnlyBuffer()
        {
            return IExecuteWithSignature<Java.Nio.FloatBuffer>("asReadOnlyBuffer", "()Ljava/nio/FloatBuffer;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/FloatBuffer.html#compact()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.FloatBuffer"/></returns>
        public Java.Nio.FloatBuffer Compact()
        {
            return IExecuteWithSignature<Java.Nio.FloatBuffer>("compact", "()Ljava/nio/FloatBuffer;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/FloatBuffer.html#put(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Java.Nio.FloatBuffer"/></returns>
        public Java.Nio.FloatBuffer Put(float arg0)
        {
            return IExecuteWithSignature<Java.Nio.FloatBuffer>("put", "(F)Ljava/nio/FloatBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/FloatBuffer.html#put(int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="Java.Nio.FloatBuffer"/></returns>
        public Java.Nio.FloatBuffer Put(int arg0, float arg1)
        {
            return IExecute<Java.Nio.FloatBuffer>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/FloatBuffer.html#put(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Java.Nio.FloatBuffer"/></returns>
        public Java.Nio.FloatBuffer Put(float[] arg0)
        {
            return IExecuteWithSignature<Java.Nio.FloatBuffer>("put", "([F)Ljava/nio/FloatBuffer;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/FloatBuffer.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/FloatBuffer.html#compareTo(java.nio.FloatBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.FloatBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Nio.FloatBuffer arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/nio/FloatBuffer;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/FloatBuffer.html#mismatch(java.nio.FloatBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.FloatBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int Mismatch(Java.Nio.FloatBuffer arg0)
        {
            return IExecuteWithSignature<int>("mismatch", "(Ljava/nio/FloatBuffer;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/FloatBuffer.html#get(float[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.FloatBuffer"/></returns>
        public Java.Nio.FloatBuffer Get(float[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Nio.FloatBuffer>("get", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/FloatBuffer.html#get(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Java.Nio.FloatBuffer"/></returns>
        public Java.Nio.FloatBuffer Get(float[] arg0)
        {
            return IExecuteWithSignature<Java.Nio.FloatBuffer>("get", "([F)Ljava/nio/FloatBuffer;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/FloatBuffer.html#put(float[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.FloatBuffer"/></returns>
        public Java.Nio.FloatBuffer Put(float[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Nio.FloatBuffer>("put", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/FloatBuffer.html#put(java.nio.FloatBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.FloatBuffer"/></param>
        /// <returns><see cref="Java.Nio.FloatBuffer"/></returns>
        public Java.Nio.FloatBuffer Put(Java.Nio.FloatBuffer arg0)
        {
            return IExecuteWithSignature<Java.Nio.FloatBuffer>("put", "(Ljava/nio/FloatBuffer;)Ljava/nio/FloatBuffer;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}