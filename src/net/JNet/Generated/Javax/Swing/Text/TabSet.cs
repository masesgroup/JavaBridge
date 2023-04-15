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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text
{
    #region TabSet
    public partial class TabSet
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabSet.html#%3Cinit%3E(javax.swing.text.TabStop[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.TabStop"/></param>
        public TabSet(Javax.Swing.Text.TabStop[] arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.TabSet"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Text.TabSet t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabSet.html#getTabCount()"/> 
        /// </summary>
        public int TabCount
        {
            get { return IExecute<int>("getTabCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabSet.html#getTabIndex(javax.swing.text.TabStop)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.TabStop"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetTabIndex(Javax.Swing.Text.TabStop arg0)
        {
            return IExecute<int>("getTabIndex", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabSet.html#getTabIndexAfter(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetTabIndexAfter(float arg0)
        {
            return IExecute<int>("getTabIndexAfter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabSet.html#getTab(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.TabStop"/></returns>
        public Javax.Swing.Text.TabStop GetTab(int arg0)
        {
            return IExecute<Javax.Swing.Text.TabStop>("getTab", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabSet.html#getTabAfter(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Javax.Swing.Text.TabStop"/></returns>
        public Javax.Swing.Text.TabStop GetTabAfter(float arg0)
        {
            return IExecute<Javax.Swing.Text.TabStop>("getTabAfter", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}