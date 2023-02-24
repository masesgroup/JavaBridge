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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region GridBagConstraints
    public partial class GridBagConstraints
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#%3Cinit%3E(int,int,int,int,double,double,int,int,java.awt.Insets,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see langword="int"/></param>
        /// <param name="arg3"><see langword="int"/></param>
        /// <param name="arg4"><see langword="double"/></param>
        /// <param name="arg5"><see langword="double"/></param>
        /// <param name="arg6"><see langword="int"/></param>
        /// <param name="arg7"><see langword="int"/></param>
        /// <param name="arg8"><see cref="Java.Awt.Insets"/></param>
        /// <param name="arg9"><see langword="int"/></param>
        /// <param name="arg10"><see langword="int"/></param>
        public GridBagConstraints(int arg0, int arg1, int arg2, int arg3, double arg4, double arg5, int arg6, int arg7, Java.Awt.Insets arg8, int arg9, int arg10)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.GridBagConstraints"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Awt.GridBagConstraints t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.GridBagConstraints"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Awt.GridBagConstraints t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#weightx"/>
        /// </summary>
        public double weightx => Instance.GetField<double>("weightx");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#weighty"/>
        /// </summary>
        public double weighty => Instance.GetField<double>("weighty");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#anchor"/>
        /// </summary>
        public int anchor => Instance.GetField<int>("anchor");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#fill"/>
        /// </summary>
        public int fill => Instance.GetField<int>("fill");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#gridheight"/>
        /// </summary>
        public int gridheight => Instance.GetField<int>("gridheight");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#gridwidth"/>
        /// </summary>
        public int gridwidth => Instance.GetField<int>("gridwidth");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#gridx"/>
        /// </summary>
        public int gridx => Instance.GetField<int>("gridx");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#gridy"/>
        /// </summary>
        public int gridy => Instance.GetField<int>("gridy");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#ipadx"/>
        /// </summary>
        public int ipadx => Instance.GetField<int>("ipadx");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#ipady"/>
        /// </summary>
        public int ipady => Instance.GetField<int>("ipady");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#insets"/>
        /// </summary>
        public Java.Awt.Insets insets => Instance.GetField<Java.Awt.Insets>("insets");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#ABOVE_BASELINE"/>
        /// </summary>
        public static int ABOVE_BASELINE => Clazz.GetField<int>("ABOVE_BASELINE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#ABOVE_BASELINE_LEADING"/>
        /// </summary>
        public static int ABOVE_BASELINE_LEADING => Clazz.GetField<int>("ABOVE_BASELINE_LEADING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#ABOVE_BASELINE_TRAILING"/>
        /// </summary>
        public static int ABOVE_BASELINE_TRAILING => Clazz.GetField<int>("ABOVE_BASELINE_TRAILING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BASELINE"/>
        /// </summary>
        public static int BASELINE => Clazz.GetField<int>("BASELINE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BASELINE_LEADING"/>
        /// </summary>
        public static int BASELINE_LEADING => Clazz.GetField<int>("BASELINE_LEADING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BASELINE_TRAILING"/>
        /// </summary>
        public static int BASELINE_TRAILING => Clazz.GetField<int>("BASELINE_TRAILING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BELOW_BASELINE"/>
        /// </summary>
        public static int BELOW_BASELINE => Clazz.GetField<int>("BELOW_BASELINE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BELOW_BASELINE_LEADING"/>
        /// </summary>
        public static int BELOW_BASELINE_LEADING => Clazz.GetField<int>("BELOW_BASELINE_LEADING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BELOW_BASELINE_TRAILING"/>
        /// </summary>
        public static int BELOW_BASELINE_TRAILING => Clazz.GetField<int>("BELOW_BASELINE_TRAILING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BOTH"/>
        /// </summary>
        public static int BOTH => Clazz.GetField<int>("BOTH");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#CENTER"/>
        /// </summary>
        public static int CENTER => Clazz.GetField<int>("CENTER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#EAST"/>
        /// </summary>
        public static int EAST => Clazz.GetField<int>("EAST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#FIRST_LINE_END"/>
        /// </summary>
        public static int FIRST_LINE_END => Clazz.GetField<int>("FIRST_LINE_END");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#FIRST_LINE_START"/>
        /// </summary>
        public static int FIRST_LINE_START => Clazz.GetField<int>("FIRST_LINE_START");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#HORIZONTAL"/>
        /// </summary>
        public static int HORIZONTAL => Clazz.GetField<int>("HORIZONTAL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#LAST_LINE_END"/>
        /// </summary>
        public static int LAST_LINE_END => Clazz.GetField<int>("LAST_LINE_END");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#LAST_LINE_START"/>
        /// </summary>
        public static int LAST_LINE_START => Clazz.GetField<int>("LAST_LINE_START");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#LINE_END"/>
        /// </summary>
        public static int LINE_END => Clazz.GetField<int>("LINE_END");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#LINE_START"/>
        /// </summary>
        public static int LINE_START => Clazz.GetField<int>("LINE_START");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#NONE"/>
        /// </summary>
        public static int NONE => Clazz.GetField<int>("NONE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#NORTH"/>
        /// </summary>
        public static int NORTH => Clazz.GetField<int>("NORTH");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#NORTHEAST"/>
        /// </summary>
        public static int NORTHEAST => Clazz.GetField<int>("NORTHEAST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#NORTHWEST"/>
        /// </summary>
        public static int NORTHWEST => Clazz.GetField<int>("NORTHWEST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#PAGE_END"/>
        /// </summary>
        public static int PAGE_END => Clazz.GetField<int>("PAGE_END");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#PAGE_START"/>
        /// </summary>
        public static int PAGE_START => Clazz.GetField<int>("PAGE_START");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#RELATIVE"/>
        /// </summary>
        public static int RELATIVE => Clazz.GetField<int>("RELATIVE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#REMAINDER"/>
        /// </summary>
        public static int REMAINDER => Clazz.GetField<int>("REMAINDER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#SOUTH"/>
        /// </summary>
        public static int SOUTH => Clazz.GetField<int>("SOUTH");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#SOUTHEAST"/>
        /// </summary>
        public static int SOUTHEAST => Clazz.GetField<int>("SOUTHEAST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#SOUTHWEST"/>
        /// </summary>
        public static int SOUTHWEST => Clazz.GetField<int>("SOUTHWEST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#VERTICAL"/>
        /// </summary>
        public static int VERTICAL => Clazz.GetField<int>("VERTICAL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#WEST"/>
        /// </summary>
        public static int WEST => Clazz.GetField<int>("WEST");
        
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
}