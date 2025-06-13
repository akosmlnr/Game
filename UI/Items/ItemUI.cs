using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000743 RID: 1859
	public class ItemUI : MonoBehaviour
	{
		// Token: 0x0600A682 RID: 42626 RVA: 0x0029E228 File Offset: 0x0029C428
		// Note: this type is marked as 'beforefieldinit'.
		static ItemUI()
		{
			Il2CppClassPointerStore<ItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUI>.NativeClassPtr);
			ItemUI.NativeFieldInfoPtr_itemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "itemInstance");
			ItemUI.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "Rect");
			ItemUI.NativeFieldInfoPtr_IconImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "IconImg");
			ItemUI.NativeFieldInfoPtr_QuantityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "QuantityLabel");
			ItemUI.NativeFieldInfoPtr_DisplayedQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "DisplayedQuantity");
			ItemUI.NativeFieldInfoPtr_Destroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "Destroyed");
			ItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683764);
			ItemUI.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683765);
			ItemUI.NativeMethodInfoPtr_DuplicateIcon_Public_Virtual_New_RectTransform_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683766);
			ItemUI.NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683767);
			ItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683768);
			ItemUI.NativeMethodInfoPtr_SetDisplayedQuantity_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683769);
			ItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683770);
		}

		// Token: 0x0600A683 RID: 42627 RVA: 0x0029E35C File Offset: 0x0029C55C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 291143, RefRangeEnd = 291148, XrefRangeStart = 291114, XrefRangeEnd = 291143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A684 RID: 42628 RVA: 0x0029E3AC File Offset: 0x0029C5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291148, XrefRangeEnd = 291166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A685 RID: 42629 RVA: 0x0029E3E8 File Offset: 0x0029C5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291166, XrefRangeEnd = 291179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RectTransform DuplicateIcon(Transform parent, int overriddenQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overriddenQuantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_DuplicateIcon_Public_Virtual_New_RectTransform_Transform_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}

		// Token: 0x0600A686 RID: 42630 RVA: 0x0029E454 File Offset: 0x0029C654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291179, XrefRangeEnd = 291182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A687 RID: 42631 RVA: 0x0029E4A0 File Offset: 0x0029C6A0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 291183, RefRangeEnd = 291189, XrefRangeStart = 291182, XrefRangeEnd = 291183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A688 RID: 42632 RVA: 0x0029E4DC File Offset: 0x0029C6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291189, XrefRangeEnd = 291192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetDisplayedQuantity(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_SetDisplayedQuantity_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A689 RID: 42633 RVA: 0x0029E528 File Offset: 0x0029C728
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A68A RID: 42634 RVA: 0x00051C9E File Offset: 0x0004FE9E
		public ItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003328 RID: 13096
		// (get) Token: 0x0600A68B RID: 42635 RVA: 0x0029E564 File Offset: 0x0029C764
		// (set) Token: 0x0600A68C RID: 42636 RVA: 0x00051CA7 File Offset: 0x0004FEA7
		public unsafe ItemInstance itemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_itemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_itemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003329 RID: 13097
		// (get) Token: 0x0600A68D RID: 42637 RVA: 0x0029E594 File Offset: 0x0029C794
		// (set) Token: 0x0600A68E RID: 42638 RVA: 0x00051CC6 File Offset: 0x0004FEC6
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700332A RID: 13098
		// (get) Token: 0x0600A68F RID: 42639 RVA: 0x0029E5C4 File Offset: 0x0029C7C4
		// (set) Token: 0x0600A690 RID: 42640 RVA: 0x00051CE5 File Offset: 0x0004FEE5
		public unsafe Image IconImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_IconImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_IconImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700332B RID: 13099
		// (get) Token: 0x0600A691 RID: 42641 RVA: 0x0029E5F4 File Offset: 0x0029C7F4
		// (set) Token: 0x0600A692 RID: 42642 RVA: 0x00051D04 File Offset: 0x0004FF04
		public unsafe TextMeshProUGUI QuantityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_QuantityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_QuantityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700332C RID: 13100
		// (get) Token: 0x0600A693 RID: 42643 RVA: 0x0029E624 File Offset: 0x0029C824
		// (set) Token: 0x0600A694 RID: 42644 RVA: 0x00051D23 File Offset: 0x0004FF23
		public unsafe int DisplayedQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_DisplayedQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_DisplayedQuantity)) = value;
			}
		}

		// Token: 0x1700332D RID: 13101
		// (get) Token: 0x0600A695 RID: 42645 RVA: 0x0029E64C File Offset: 0x0029C84C
		// (set) Token: 0x0600A696 RID: 42646 RVA: 0x00051D3E File Offset: 0x0004FF3E
		public unsafe bool Destroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_Destroyed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_Destroyed)) = value;
			}
		}

		// Token: 0x04006FAD RID: 28589
		private static readonly IntPtr NativeFieldInfoPtr_itemInstance;

		// Token: 0x04006FAE RID: 28590
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04006FAF RID: 28591
		private static readonly IntPtr NativeFieldInfoPtr_IconImg;

		// Token: 0x04006FB0 RID: 28592
		private static readonly IntPtr NativeFieldInfoPtr_QuantityLabel;

		// Token: 0x04006FB1 RID: 28593
		private static readonly IntPtr NativeFieldInfoPtr_DisplayedQuantity;

		// Token: 0x04006FB2 RID: 28594
		private static readonly IntPtr NativeFieldInfoPtr_Destroyed;

		// Token: 0x04006FB3 RID: 28595
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04006FB4 RID: 28596
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0;

		// Token: 0x04006FB5 RID: 28597
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateIcon_Public_Virtual_New_RectTransform_Transform_Int32_0;

		// Token: 0x04006FB6 RID: 28598
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04006FB7 RID: 28599
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0;

		// Token: 0x04006FB8 RID: 28600
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedQuantity_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04006FB9 RID: 28601
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
