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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*/

package org.mases.jnet.generated.java.util.function;

public final class DoublePredicate extends org.mases.jcobridge.JCListener implements java.util.function.DoublePredicate {
    public DoublePredicate(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public boolean test(double arg0) {
        raiseEvent("test", arg0); Object retVal = getReturnData(); return (boolean)retVal;
    }
    //@Override
    public java.util.function.DoublePredicate and(java.util.function.DoublePredicate arg0) {
        raiseEvent("and", arg0); Object retVal = getReturnData(); return (java.util.function.DoublePredicate)retVal;
    }
    //@Override
    public java.util.function.DoublePredicate andDefault(java.util.function.DoublePredicate arg0) {
        return java.util.function.DoublePredicate.super.and(arg0);
    }
    //@Override
    public java.util.function.DoublePredicate negate() {
        raiseEvent("negate"); Object retVal = getReturnData(); return (java.util.function.DoublePredicate)retVal;
    }
    //@Override
    public java.util.function.DoublePredicate negateDefault() {
        return java.util.function.DoublePredicate.super.negate();
    }
    //@Override
    public java.util.function.DoublePredicate or(java.util.function.DoublePredicate arg0) {
        raiseEvent("or", arg0); Object retVal = getReturnData(); return (java.util.function.DoublePredicate)retVal;
    }
    //@Override
    public java.util.function.DoublePredicate orDefault(java.util.function.DoublePredicate arg0) {
        return java.util.function.DoublePredicate.super.or(arg0);
    }

}