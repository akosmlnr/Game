using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x02000719 RID: 1817
	public class PromptImage : MonoBehaviour
	{
		// Token: 0x0600A1AC RID: 41388 RVA: 0x0028EE60 File Offset: 0x0028D060
		// Note: this type is marked as 'beforefieldinit'.
		static PromptImage()
		{
			Il2CppClassPointerStore<PromptImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "PromptImage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromptImage>.NativeClassPtr);
			PromptImage.NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptImage>.NativeClassPtr, "Width");
			PromptImage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptImage>.NativeClassPtr, 100683214);
		}

		// Token: 0x0600A1AD RID: 41389 RVA: 0x0028EEB8 File Offset: 0x0028D0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285688, XrefRangeEnd = 285689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PromptImage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromptImage>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptImage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A1AE RID: 41390 RVA: 0x0004F1A0 File Offset: 0x0004D3A0
		public PromptImage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700318F RID: 12687
		// (get) Token: 0x0600A1AF RID: 41391 RVA: 0x0028EEF4 File Offset: 0x0028D0F4
		// (set) Token: 0x0600A1B0 RID: 41392 RVA: 0x0004F1A9 File Offset: 0x0004D3A9
		public unsafe float Width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptImage.NativeFieldInfoPtr_Width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptImage.NativeFieldInfoPtr_Width)) = value;
			}
		}

		// Token: 0x04006C7D RID: 27773
		private static readonly IntPtr NativeFieldInfoPtr_Width;

		// Token: 0x04006C7E RID: 27774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
