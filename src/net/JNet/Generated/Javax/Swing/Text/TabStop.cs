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

namespace Javax.Swing.Text
{
    #region TabStop
    public partial class TabStop
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#%3Cinit%3E(float,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public TabStop(float arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#%3Cinit%3E(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public TabStop(float arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.TabStop"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Text.TabStop t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#ALIGN_BAR"/>
        /// </summary>
        public static int ALIGN_BAR => Clazz.GetField<int>("ALIGN_BAR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#ALIGN_CENTER"/>
        /// </summary>
        public static int ALIGN_CENTER => Clazz.GetField<int>("ALIGN_CENTER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#ALIGN_DECIMAL"/>
        /// </summary>
        public static int ALIGN_DECIMAL => Clazz.GetField<int>("ALIGN_DECIMAL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#ALIGN_LEFT"/>
        /// </summary>
        public static int ALIGN_LEFT => Clazz.GetField<int>("ALIGN_LEFT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#ALIGN_RIGHT"/>
        /// </summary>
        public static int ALIGN_RIGHT => Clazz.GetField<int>("ALIGN_RIGHT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#LEAD_DOTS"/>
        /// </summary>
        public static int LEAD_DOTS => Clazz.GetField<int>("LEAD_DOTS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#LEAD_EQUALS"/>
        /// </summary>
        public static int LEAD_EQUALS => Clazz.GetField<int>("LEAD_EQUALS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#LEAD_HYPHENS"/>
        /// </summary>
        public static int LEAD_HYPHENS => Clazz.GetField<int>("LEAD_HYPHENS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#LEAD_NONE"/>
        /// </summary>
        public static int LEAD_NONE => Clazz.GetField<int>("LEAD_NONE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#LEAD_THICKLINE"/>
        /// </summary>
        public static int LEAD_THICKLINE => Clazz.GetField<int>("LEAD_THICKLINE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#LEAD_UNDERLINE"/>
        /// </summary>
        public static int LEAD_UNDERLINE => Clazz.GetField<int>("LEAD_UNDERLINE");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#getAlignment()"/> 
        /// </summary>
        public int Alignment
        {
            get { return IExecute<int>("getAlignment"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#getLeader()"/> 
        /// </summary>
        public int Leader
        {
            get { return IExecute<int>("getLeader"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#getPosition()"/> 
        /// </summary>
        public float Position
        {
            get { return IExecute<float>("getPosition"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}