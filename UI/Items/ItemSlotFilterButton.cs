using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000742 RID: 1858
	public class ItemSlotFilterButton : MonoBehaviour
	{
		// Token: 0x0600A66A RID: 42602 RVA: 0x0029DDA8 File Offset: 0x0029BFA8
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSlotFilterButton()
		{
			Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemSlotFilterButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr);
			ItemSlotFilterButton.NativeFieldInfoPtr__AssignedSlot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, "<AssignedSlot>k__BackingField");
			ItemSlotFilterButton.NativeFieldInfoPtr_ItemSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, "ItemSlotUI");
			ItemSlotFilterButton.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, "Button");
			ItemSlotFilterButton.NativeFieldInfoPtr_IconImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, "IconImage");
			ItemSlotFilterButton.NativeFieldInfoPtr_SpotImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, "SpotImage");
			ItemSlotFilterButton.NativeFieldInfoPtr_FilterItemImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, "FilterItemImages");
			ItemSlotFilterButton.NativeFieldInfoPtr_FilterMoreItemsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, "FilterMoreItemsLabel");
			ItemSlotFilterButton.NativeMethodInfoPtr_get_AssignedSlot_Public_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, 100683756);
			ItemSlotFilterButton.NativeMethodInfoPtr_set_AssignedSlot_Protected_set_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, 100683757);
			ItemSlotFilterButton.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, 100683758);
			ItemSlotFilterButton.NativeMethodInfoPtr_AssignSlot_Public_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, 100683759);
			ItemSlotFilterButton.NativeMethodInfoPtr_UnassignSlot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, 100683760);
			ItemSlotFilterButton.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, 100683761);
			ItemSlotFilterButton.NativeMethodInfoPtr_RefreshAppearance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, 100683762);
			ItemSlotFilterButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, 100683763);
		}

		// Token: 0x17003327 RID: 13095
		// (get) Token: 0x0600A66B RID: 42603 RVA: 0x0029DF04 File Offset: 0x0029C104
		// (set) Token: 0x0600A66C RID: 42604 RVA: 0x0029DF44 File Offset: 0x0029C144
		public unsafe ItemSlot AssignedSlot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotFilterButton.NativeMethodInfoPtr_get_AssignedSlot_Public_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotFilterButton.NativeMethodInfoPtr_set_AssignedSlot_Protected_set_Void_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A66D RID: 42605 RVA: 0x0029DF88 File Offset: 0x0029C188
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotFilterButton.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A66E RID: 42606 RVA: 0x0029DFBC File Offset: 0x0029C1BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291072, RefRangeEnd = 291073, XrefRangeStart = 291014, XrefRangeEnd = 291072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignSlot(ItemSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotFilterButton.NativeMethodInfoPtr_AssignSlot_Public_Void_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A66F RID: 42607 RVA: 0x0029E000 File Offset: 0x0029C200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291087, RefRangeEnd = 291088, XrefRangeStart = 291073, XrefRangeEnd = 291087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnassignSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotFilterButton.NativeMethodInfoPtr_UnassignSlot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A670 RID: 42608 RVA: 0x0029E034 File Offset: 0x0029C234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291088, XrefRangeEnd = 291097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotFilterButton.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A671 RID: 42609 RVA: 0x0029E068 File Offset: 0x0029C268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291097, XrefRangeEnd = 291114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshAppearance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotFilterButton.NativeMethodInfoPtr_RefreshAppearance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A672 RID: 42610 RVA: 0x0029E09C File Offset: 0x0029C29C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotFilterButton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotFilterButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A673 RID: 42611 RVA: 0x00051BBC File Offset: 0x0004FDBC
		public ItemSlotFilterButton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003320 RID: 13088
		// (get) Token: 0x0600A674 RID: 42612 RVA: 0x0029E0D8 File Offset: 0x0029C2D8
		// (set) Token: 0x0600A675 RID: 42613 RVA: 0x00051BC5 File Offset: 0x0004FDC5
		public unsafe ItemSlot _AssignedSlot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr__AssignedSlot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr__AssignedSlot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003321 RID: 13089
		// (get) Token: 0x0600A676 RID: 42614 RVA: 0x0029E108 File Offset: 0x0029C308
		// (set) Token: 0x0600A677 RID: 42615 RVA: 0x00051BE4 File Offset: 0x0004FDE4
		public unsafe ItemSlotUI ItemSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_ItemSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_ItemSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003322 RID: 13090
		// (get) Token: 0x0600A678 RID: 42616 RVA: 0x0029E138 File Offset: 0x0029C338
		// (set) Token: 0x0600A679 RID: 42617 RVA: 0x00051C03 File Offset: 0x0004FE03
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003323 RID: 13091
		// (get) Token: 0x0600A67A RID: 42618 RVA: 0x0029E168 File Offset: 0x0029C368
		// (set) Token: 0x0600A67B RID: 42619 RVA: 0x00051C22 File Offset: 0x0004FE22
		public unsafe Image IconImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_IconImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_IconImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003324 RID: 13092
		// (get) Token: 0x0600A67C RID: 42620 RVA: 0x0029E198 File Offset: 0x0029C398
		// (set) Token: 0x0600A67D RID: 42621 RVA: 0x00051C41 File Offset: 0x0004FE41
		public unsafe Image SpotImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_SpotImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_SpotImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003325 RID: 13093
		// (get) Token: 0x0600A67E RID: 42622 RVA: 0x0029E1C8 File Offset: 0x0029C3C8
		// (set) Token: 0x0600A67F RID: 42623 RVA: 0x00051C60 File Offset: 0x0004FE60
		public unsafe Il2CppReferenceArray<Image> FilterItemImages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_FilterItemImages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_FilterItemImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003326 RID: 13094
		// (get) Token: 0x0600A680 RID: 42624 RVA: 0x0029E1F8 File Offset: 0x0029C3F8
		// (set) Token: 0x0600A681 RID: 42625 RVA: 0x00051C7F File Offset: 0x0004FE7F
		public unsafe TextMeshProUGUI FilterMoreItemsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_FilterMoreItemsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_FilterMoreItemsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006F9E RID: 28574
		private static readonly IntPtr NativeFieldInfoPtr__AssignedSlot_k__BackingField;

		// Token: 0x04006F9F RID: 28575
		private static readonly IntPtr NativeFieldInfoPtr_ItemSlotUI;

		// Token: 0x04006FA0 RID: 28576
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x04006FA1 RID: 28577
		private static readonly IntPtr NativeFieldInfoPtr_IconImage;

		// Token: 0x04006FA2 RID: 28578
		private static readonly IntPtr NativeFieldInfoPtr_SpotImage;

		// Token: 0x04006FA3 RID: 28579
		private static readonly IntPtr NativeFieldInfoPtr_FilterItemImages;

		// Token: 0x04006FA4 RID: 28580
		private static readonly IntPtr NativeFieldInfoPtr_FilterMoreItemsLabel;

		// Token: 0x04006FA5 RID: 28581
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedSlot_Public_get_ItemSlot_0;

		// Token: 0x04006FA6 RID: 28582
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedSlot_Protected_set_Void_ItemSlot_0;

		// Token: 0x04006FA7 RID: 28583
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006FA8 RID: 28584
		private static readonly IntPtr NativeMethodInfoPtr_AssignSlot_Public_Void_ItemSlot_0;

		// Token: 0x04006FA9 RID: 28585
		private static readonly IntPtr NativeMethodInfoPtr_UnassignSlot_Public_Void_0;

		// Token: 0x04006FAA RID: 28586
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x04006FAB RID: 28587
		private static readonly IntPtr NativeMethodInfoPtr_RefreshAppearance_Private_Void_0;

		// Token: 0x04006FAC RID: 28588
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
