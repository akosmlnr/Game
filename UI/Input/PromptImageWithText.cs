using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x0200071A RID: 1818
	public class PromptImageWithText : PromptImage
	{
		// Token: 0x0600A1B1 RID: 41393 RVA: 0x0028EF1C File Offset: 0x0028D11C
		// Note: this type is marked as 'beforefieldinit'.
		static PromptImageWithText()
		{
			Il2CppClassPointerStore<PromptImageWithText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "PromptImageWithText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromptImageWithText>.NativeClassPtr);
			PromptImageWithText.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptImageWithText>.NativeClassPtr, "Label");
			PromptImageWithText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptImageWithText>.NativeClassPtr, 100683215);
		}

		// Token: 0x0600A1B2 RID: 41394 RVA: 0x0028EF74 File Offset: 0x0028D174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PromptImageWithText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromptImageWithText>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptImageWithText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A1B3 RID: 41395 RVA: 0x0004F1C4 File Offset: 0x0004D3C4
		public PromptImageWithText(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003190 RID: 12688
		// (get) Token: 0x0600A1B4 RID: 41396 RVA: 0x0028EFB0 File Offset: 0x0028D1B0
		// (set) Token: 0x0600A1B5 RID: 41397 RVA: 0x0004F1CD File Offset: 0x0004D3CD
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptImageWithText.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptImageWithText.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006C7F RID: 27775
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04006C80 RID: 27776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
