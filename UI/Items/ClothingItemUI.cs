using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x0200073C RID: 1852
	public class ClothingItemUI : ItemUI
	{
		// Token: 0x0600A5CB RID: 42443 RVA: 0x0029BF1C File Offset: 0x0029A11C
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingItemUI()
		{
			Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ClothingItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr);
			ClothingItemUI.NativeFieldInfoPtr_ClothingTypeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr, "ClothingTypeIcon");
			ClothingItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr, 100683682);
			ClothingItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr, 100683683);
		}

		// Token: 0x0600A5CC RID: 42444 RVA: 0x0029BF88 File Offset: 0x0029A188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290264, XrefRangeEnd = 290282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5CD RID: 42445 RVA: 0x0029BFC4 File Offset: 0x0029A1C4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5CE RID: 42446 RVA: 0x00051626 File Offset: 0x0004F826
		public ClothingItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032EE RID: 13038
		// (get) Token: 0x0600A5CF RID: 42447 RVA: 0x0029C000 File Offset: 0x0029A200
		// (set) Token: 0x0600A5D0 RID: 42448 RVA: 0x0005162F File Offset: 0x0004F82F
		public unsafe Image ClothingTypeIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingItemUI.NativeFieldInfoPtr_ClothingTypeIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingItemUI.NativeFieldInfoPtr_ClothingTypeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006F39 RID: 28473
		private static readonly IntPtr NativeFieldInfoPtr_ClothingTypeIcon;

		// Token: 0x04006F3A RID: 28474
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x04006F3B RID: 28475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
