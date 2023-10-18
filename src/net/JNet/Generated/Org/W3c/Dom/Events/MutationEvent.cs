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

namespace Org.W3c.Dom.Events
{
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
        string AttrName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getNewValue()"/> 
        /// </summary>
        string NewValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getPrevValue()"/> 
        /// </summary>
        string PrevValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getRelatedNode()"/> 
        /// </summary>
        Org.W3c.Dom.Node RelatedNode { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#initMutationEvent(java.lang.String,boolean,boolean,org.w3c.dom.Node,java.lang.String,java.lang.String,java.lang.String,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <param name="arg5"><see cref="string"/></param>
        /// <param name="arg6"><see cref="string"/></param>
        /// <param name="arg7"><see cref="short"/></param>
        void InitMutationEvent(string arg0, bool arg1, bool arg2, Org.W3c.Dom.Node arg3, string arg4, string arg5, string arg6, short arg7);

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
        public static short ADDITION { get { return SGetField<short>(LocalBridgeClazz, "ADDITION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#MODIFICATION"/>
        /// </summary>
        public static short MODIFICATION { get { return SGetField<short>(LocalBridgeClazz, "MODIFICATION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#REMOVAL"/>
        /// </summary>
        public static short REMOVAL { get { return SGetField<short>(LocalBridgeClazz, "REMOVAL"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getAttrChange()"/> 
        /// </summary>
        public short AttrChange
        {
            get { return IExecute<short>("getAttrChange"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getAttrName()"/> 
        /// </summary>
        public string AttrName
        {
            get { return IExecute<string>("getAttrName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getNewValue()"/> 
        /// </summary>
        public string NewValue
        {
            get { return IExecute<string>("getNewValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getPrevValue()"/> 
        /// </summary>
        public string PrevValue
        {
            get { return IExecute<string>("getPrevValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#getRelatedNode()"/> 
        /// </summary>
        public Org.W3c.Dom.Node RelatedNode
        {
            get { return IExecute<Org.W3c.Dom.Node>("getRelatedNode"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/MutationEvent.html#initMutationEvent(java.lang.String,boolean,boolean,org.w3c.dom.Node,java.lang.String,java.lang.String,java.lang.String,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <param name="arg5"><see cref="string"/></param>
        /// <param name="arg6"><see cref="string"/></param>
        /// <param name="arg7"><see cref="short"/></param>
        public void InitMutationEvent(string arg0, bool arg1, bool arg2, Org.W3c.Dom.Node arg3, string arg4, string arg5, string arg6, short arg7)
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