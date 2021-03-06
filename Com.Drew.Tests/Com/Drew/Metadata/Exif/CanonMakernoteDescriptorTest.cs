/*
 * Copyright 2002-2013 Drew Noakes
 *
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *
 * More information about this project is available at:
 *
 *    http://drewnoakes.com/code/exif/
 *    http://code.google.com/p/metadata-extractor/
 */
 using Com.Drew.Metadata.Exif;
using Com.Drew.Metadata.Exif.Makernotes;
 using NUnit.Framework;
 using Sharpen;

namespace Com.Drew.Metadata.Exif
{
	/// <author>Drew Noakes http://drewnoakes.com</author>
	public class CanonMakernoteDescriptorTest
	{
		/// <exception cref="System.Exception"/>
        [NUnit.Framework.Test, SetCulture("en-US")]
		public virtual void TestGetFlashBiasDescription()
		{
			CanonMakernoteDirectory directory = new CanonMakernoteDirectory();
			CanonMakernoteDescriptor descriptor = new CanonMakernoteDescriptor(directory);
			// set and check values
			directory.SetInt(CanonMakernoteDirectory.FocalLength.TagFlashBias, unchecked((int)(0xFFC0)));
			Sharpen.Tests.AreEqual("-2.0 EV", descriptor.GetDescription(CanonMakernoteDirectory.FocalLength.TagFlashBias));
			directory.SetInt(CanonMakernoteDirectory.FocalLength.TagFlashBias, unchecked((int)(0xffd4)));
			Sharpen.Tests.AreEqual("-1.375 EV", descriptor.GetDescription(CanonMakernoteDirectory.FocalLength.TagFlashBias));
			directory.SetInt(CanonMakernoteDirectory.FocalLength.TagFlashBias, unchecked((int)(0x0000)));
			Sharpen.Tests.AreEqual("0.0 EV", descriptor.GetDescription(CanonMakernoteDirectory.FocalLength.TagFlashBias));
			directory.SetInt(CanonMakernoteDirectory.FocalLength.TagFlashBias, unchecked((int)(0x000c)));
			Sharpen.Tests.AreEqual("0.375 EV", descriptor.GetDescription(CanonMakernoteDirectory.FocalLength.TagFlashBias));
			directory.SetInt(CanonMakernoteDirectory.FocalLength.TagFlashBias, unchecked((int)(0x0010)));
			Sharpen.Tests.AreEqual("0.5 EV", descriptor.GetDescription(CanonMakernoteDirectory.FocalLength.TagFlashBias));
			directory.SetInt(CanonMakernoteDirectory.FocalLength.TagFlashBias, unchecked((int)(0x0014)));
			Sharpen.Tests.AreEqual("0.625 EV", descriptor.GetDescription(CanonMakernoteDirectory.FocalLength.TagFlashBias));
			directory.SetInt(CanonMakernoteDirectory.FocalLength.TagFlashBias, unchecked((int)(0x0020)));
			Sharpen.Tests.AreEqual("1.0 EV", descriptor.GetDescription(CanonMakernoteDirectory.FocalLength.TagFlashBias));
			directory.SetInt(CanonMakernoteDirectory.FocalLength.TagFlashBias, unchecked((int)(0x0030)));
			Sharpen.Tests.AreEqual("1.5 EV", descriptor.GetDescription(CanonMakernoteDirectory.FocalLength.TagFlashBias));
			directory.SetInt(CanonMakernoteDirectory.FocalLength.TagFlashBias, unchecked((int)(0x0034)));
			Sharpen.Tests.AreEqual("1.625 EV", descriptor.GetDescription(CanonMakernoteDirectory.FocalLength.TagFlashBias));
			directory.SetInt(CanonMakernoteDirectory.FocalLength.TagFlashBias, unchecked((int)(0x0040)));
			Sharpen.Tests.AreEqual("2.0 EV", descriptor.GetDescription(CanonMakernoteDirectory.FocalLength.TagFlashBias));
		}
	}
}
