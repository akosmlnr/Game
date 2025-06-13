using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Management.Presets.Options
{
	// Token: 0x020003CE RID: 974
	public class GenericOptionUI : MonoBehaviour
	{
		// Token: 0x06004B12 RID: 19218 RVA: 0x0016EE14 File Offset: 0x0016D014
		// Note: this type is marked as 'beforefieldinit'.
		static GenericOptionUI()
		{
			Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Presets.Options", "GenericOptionUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr);
			GenericOptionUI.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr, "Button");
			GenericOptionUI.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr, "NameLabel");
			GenericOptionUI.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr, "ValueLabel");
			GenericOptionUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr, 100672694);
		}

		// Token: 0x06004B13 RID: 19219 RVA: 0x0016EE94 File Offset: 0x0016D094
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericOptionUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericOptionUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B14 RID: 19220 RVA: 0x00023FA1 File Offset: 0x000221A1
		public GenericOptionUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x06004B15 RID: 19221 RVA: 0x0016EED0 File Offset: 0x0016D0D0
		// (set) Token: 0x06004B16 RID: 19222 RVA: 0x00023FAA File Offset: 0x000221AA
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionUI.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionUI.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06004B17 RID: 19223 RVA: 0x0016EF00 File Offset: 0x0016D100
		// (set) Token: 0x06004B18 RID: 19224 RVA: 0x00023FC9 File Offset: 0x000221C9
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionUI.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionUI.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x06004B19 RID: 19225 RVA: 0x0016EF30 File Offset: 0x0016D130
		// (set) Token: 0x06004B1A RID: 19226 RVA: 0x00023FE8 File Offset: 0x000221E8
		public unsafe TextMeshProUGUI ValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionUI.NativeFieldInfoPtr_ValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionUI.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400329C RID: 12956
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x0400329D RID: 12957
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x0400329E RID: 12958
		private static readonly IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x0400329F RID: 12959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
