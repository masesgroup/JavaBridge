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

namespace Org.W3c.Dom.Events
{
    #region MutationEvent definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html"/>
    /// </summary>
    public partial class MutationEvent : Org.W3c.Dom.Events.Event
    {
        const string _bridgeClassName = "org.w3c.dom.events.MutationEvent";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("MutationEvent class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public MutationEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("MutationEvent class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public MutationEvent(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IMutationEvent
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMutationEvent : Org.W3c.Dom.Events.IEvent
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getAttrChange()"/> 
        /// </summary>
        short AttrChange { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getAttrName()"/> 
        /// </summary>
        Java.Lang.String AttrName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getNewValue()"/> 
        /// </summary>
        Java.Lang.String NewValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getPrevValue()"/> 
        /// </summary>
        Java.Lang.String PrevValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getRelatedNode()"/> 
        /// </summary>
        Org.W3c.Dom.Node RelatedNode { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#initMutationEvent(java.lang.String,boolean,boolean,org.w3c.dom.Node,java.lang.String,java.lang.String,java.lang.String,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="Java.Lang.String"/></param>
        /// <param name="arg6"><see cref="Java.Lang.String"/></param>
        /// <param name="arg7"><see cref="short"/></param>
        void InitMutationEvent(Java.Lang.String arg0, bool arg1, bool arg2, Org.W3c.Dom.Node arg3, Java.Lang.String arg4, Java.Lang.String arg5, Java.Lang.String arg6, short arg7);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MutationEvent
    public partial class MutationEvent : Org.W3c.Dom.Events.IMutationEvent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#ADDITION"/>
        /// </summary>
        public static short ADDITION { get { if (!_ADDITIONReady) { _ADDITIONContent = SGetField<short>(LocalBridgeClazz, "ADDITION"); _ADDITIONReady = true; } return _ADDITIONContent; } }
        private static short _ADDITIONContent = default;
        private static bool _ADDITIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#MODIFICATION"/>
        /// </summary>
        public static short MODIFICATION { get { if (!_MODIFICATIONReady) { _MODIFICATIONContent = SGetField<short>(LocalBridgeClazz, "MODIFICATION"); _MODIFICATIONReady = true; } return _MODIFICATIONContent; } }
        private static short _MODIFICATIONContent = default;
        private static bool _MODIFICATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#REMOVAL"/>
        /// </summary>
        public static short REMOVAL { get { if (!_REMOVALReady) { _REMOVALContent = SGetField<short>(LocalBridgeClazz, "REMOVAL"); _REMOVALReady = true; } return _REMOVALContent; } }
        private static short _REMOVALContent = default;
        private static bool _REMOVALReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getAttrChange()"/> 
        /// </summary>
        public short AttrChange
        {
            get { return IExecuteWithSignature<short>("getAttrChange", "()S"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getAttrName()"/> 
        /// </summary>
        public Java.Lang.String AttrName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAttrName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getNewValue()"/> 
        /// </summary>
        public Java.Lang.String NewValue
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getNewValue", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getPrevValue()"/> 
        /// </summary>
        public Java.Lang.String PrevValue
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPrevValue", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getRelatedNode()"/> 
        /// </summary>
        public Org.W3c.Dom.Node RelatedNode
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getRelatedNode", "()Lorg/w3c/dom/Node;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#initMutationEvent(java.lang.String,boolean,boolean,org.w3c.dom.Node,java.lang.String,java.lang.String,java.lang.String,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="Java.Lang.String"/></param>
        /// <param name="arg6"><see cref="Java.Lang.String"/></param>
        /// <param name="arg7"><see cref="short"/></param>
        public void InitMutationEvent(Java.Lang.String arg0, bool arg1, bool arg2, Org.W3c.Dom.Node arg3, Java.Lang.String arg4, Java.Lang.String arg5, Java.Lang.String arg6, short arg7)
        {
            IExecute("initMutationEvent", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}