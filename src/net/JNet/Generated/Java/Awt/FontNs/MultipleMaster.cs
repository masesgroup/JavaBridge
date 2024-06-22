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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.FontNs
{
    #region IMultipleMaster
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMultipleMaster
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/MultipleMaster.html#getDesignAxisDefaults()"/> 
        /// </summary>
        float[] DesignAxisDefaults { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/MultipleMaster.html#getDesignAxisNames()"/> 
        /// </summary>
        Java.Lang.String[] DesignAxisNames { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/MultipleMaster.html#getDesignAxisRanges()"/> 
        /// </summary>
        float[] DesignAxisRanges { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/MultipleMaster.html#getNumDesignAxes()"/> 
        /// </summary>
        int NumDesignAxes { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/MultipleMaster.html#deriveMMFont(float[],float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        Java.Awt.Font DeriveMMFont(float[] arg0, float arg1, float arg2, float arg3, float arg4);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/MultipleMaster.html#deriveMMFont(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        Java.Awt.Font DeriveMMFont(float[] arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MultipleMaster
    public partial class MultipleMaster : Java.Awt.FontNs.IMultipleMaster
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/MultipleMaster.html#getDesignAxisDefaults()"/> 
        /// </summary>
        public float[] DesignAxisDefaults
        {
            get { return IExecuteWithSignatureArray<float>("getDesignAxisDefaults", "()[F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/MultipleMaster.html#getDesignAxisNames()"/> 
        /// </summary>
        public Java.Lang.String[] DesignAxisNames
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getDesignAxisNames", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/MultipleMaster.html#getDesignAxisRanges()"/> 
        /// </summary>
        public float[] DesignAxisRanges
        {
            get { return IExecuteWithSignatureArray<float>("getDesignAxisRanges", "()[F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/MultipleMaster.html#getNumDesignAxes()"/> 
        /// </summary>
        public int NumDesignAxes
        {
            get { return IExecuteWithSignature<int>("getNumDesignAxes", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/MultipleMaster.html#deriveMMFont(float[],float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public Java.Awt.Font DeriveMMFont(float[] arg0, float arg1, float arg2, float arg3, float arg4)
        {
            return IExecute<Java.Awt.Font>("deriveMMFont", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/MultipleMaster.html#deriveMMFont(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public Java.Awt.Font DeriveMMFont(float[] arg0)
        {
            return IExecuteWithSignature<Java.Awt.Font>("deriveMMFont", "([F)Ljava/awt/Font;", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}