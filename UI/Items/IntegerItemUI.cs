using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x0200073E RID: 1854
	public class IntegerItemUI : ItemUI
	{
		// Token: 0x0600A630 RID: 42544 RVA: 0x0029D324 File Offset: 0x0029B524
		// Note: this type is marked as 'beforefieldinit'.
		static IntegerItemUI()
		{
			Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "IntegerItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr);
			IntegerItemUI.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr, "ValueLabel");
			IntegerItemUI.NativeFieldInfoPtr_integerItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr, "integerItemInstance");
			IntegerItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr, 100683740);
			IntegerItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr, 100683741);
			IntegerItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr, 100683742);
		}

		// Token: 0x0600A631 RID: 42545 RVA: 0x0029D3B8 File Offset: 0x0029B5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290911, XrefRangeEnd = 290917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A632 RID: 42546 RVA: 0x0029D408 File Offset: 0x0029B608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290917, XrefRangeEnd = 290919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A633 RID: 42547 RVA: 0x0029D444 File Offset: 0x0029B644
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegerItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A634 RID: 42548 RVA: 0x000519A6 File Offset: 0x0004FBA6
		public IntegerItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700330D RID: 13069
		// (get) Token: 0x0600A635 RID: 42549 RVA: 0x0029D480 File Offset: 0x0029B680
		// (set) Token: 0x0600A636 RID: 42550 RVA: 0x000519AF File Offset: 0x0004FBAF
		public unsafe Text ValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemUI.NativeFieldInfoPtr_ValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemUI.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700330E RID: 13070
		// (get) Token: 0x0600A637 RID: 42551 RVA: 0x0029D4B0 File Offset: 0x0029B6B0
		// (set) Token: 0x0600A638 RID: 42552 RVA: 0x000519CE File Offset: 0x0004FBCE
		public unsafe IntegerItemInstance integerItemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemUI.NativeFieldInfoPtr_integerItemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntegerItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemUI.NativeFieldInfoPtr_integerItemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006F7D RID: 28541
		private static readonly IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x04006F7E RID: 28542
		private static readonly IntPtr NativeFieldInfoPtr_integerItemInstance;

		// Token: 0x04006F7F RID: 28543
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04006F80 RID: 28544
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x04006F81 RID: 28545
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
