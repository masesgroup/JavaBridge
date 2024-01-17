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

namespace Org.W3c.Dom.Ls
{
    #region ILSProgressEvent
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ILSProgressEvent : Org.W3c.Dom.Events.IEvent
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSProgressEvent.html#getInput()"/> 
        /// </summary>
        Org.W3c.Dom.Ls.LSInput Input { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSProgressEvent.html#getPosition()"/> 
        /// </summary>
        int Position { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSProgressEvent.html#getTotalSize()"/> 
        /// </summary>
        int TotalSize { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LSProgressEvent
    public partial class LSProgressEvent : Org.W3c.Dom.Ls.ILSProgressEvent
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSProgressEvent.html#getInput()"/> 
        /// </summary>
        public Org.W3c.Dom.Ls.LSInput Input
        {
            get { return IExecute<Org.W3c.Dom.Ls.LSInput>("getInput"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSProgressEvent.html#getPosition()"/> 
        /// </summary>
        public int Position
        {
            get { return IExecute<int>("getPosition"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSProgressEvent.html#getTotalSize()"/> 
        /// </summary>
        public int TotalSize
        {
            get { return IExecute<int>("getTotalSize"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}