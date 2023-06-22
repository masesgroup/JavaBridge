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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region SpinnerDateModel
    public partial class SpinnerDateModel
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerDateModel.html#%3Cinit%3E(java.util.Date,java.lang.Comparable,java.lang.Comparable,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Comparable"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Comparable"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public SpinnerDateModel(Java.Util.Date arg0, Java.Lang.Comparable<Java.Util.Date> arg1, Java.Lang.Comparable<Java.Util.Date> arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerDateModel.html#getCalendarField()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerDateModel.html#setCalendarField(int)"/>
        /// </summary>
        public int CalendarField
        {
            get { return IExecute<int>("getCalendarField"); } set { IExecute("setCalendarField", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerDateModel.html#getDate()"/> 
        /// </summary>
        public Java.Util.Date Date
        {
            get { return IExecute<Java.Util.Date>("getDate"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerDateModel.html#getEnd()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerDateModel.html#setEnd(java.lang.Comparable)"/>
        /// </summary>
        public Java.Lang.Comparable<Java.Util.Date> End
        {
            get { return IExecute<Java.Lang.Comparable<Java.Util.Date>>("getEnd"); } set { IExecute("setEnd", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerDateModel.html#getStart()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerDateModel.html#setStart(java.lang.Comparable)"/>
        /// </summary>
        public Java.Lang.Comparable<Java.Util.Date> Start
        {
            get { return IExecute<Java.Lang.Comparable<Java.Util.Date>>("getStart"); } set { IExecute("setStart", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}