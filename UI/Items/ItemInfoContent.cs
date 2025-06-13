using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000740 RID: 1856
	public class ItemInfoContent : MonoBehaviour
	{
		// Token: 0x0600A63E RID: 42558 RVA: 0x0029D5A4 File Offset: 0x0029B7A4
		// Note: this type is marked as 'beforefieldinit'.
		static ItemInfoContent()
		{
			Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemInfoContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr);
			ItemInfoContent.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, "Height");
			ItemInfoContent.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, "NameLabel");
			ItemInfoContent.NativeFieldInfoPtr_DescriptionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, "DescriptionLabel");
			ItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, 100683744);
			ItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, 100683745);
			ItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, 100683746);
		}

		// Token: 0x0600A63F RID: 42559 RVA: 0x0029D64C File Offset: 0x0029B84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290919, XrefRangeEnd = 290920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A640 RID: 42560 RVA: 0x0029D69C File Offset: 0x0029B89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290920, XrefRangeEnd = 290921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(ItemDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A641 RID: 42561 RVA: 0x0029D6EC File Offset: 0x0029B8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290921, XrefRangeEnd = 290922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInfoContent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A642 RID: 42562 RVA: 0x00051A15 File Offset: 0x0004FC15
		public ItemInfoContent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003310 RID: 13072
		// (get) Token: 0x0600A643 RID: 42563 RVA: 0x0029D728 File Offset: 0x0029B928
		// (set) Token: 0x0600A644 RID: 42564 RVA: 0x00051A1E File Offset: 0x0004FC1E
		public unsafe float Height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_Height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_Height)) = value;
			}
		}

		// Token: 0x17003311 RID: 13073
		// (get) Token: 0x0600A645 RID: 42565 RVA: 0x0029D750 File Offset: 0x0029B950
		// (set) Token: 0x0600A646 RID: 42566 RVA: 0x00051A39 File Offset: 0x0004FC39
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003312 RID: 13074
		// (get) Token: 0x0600A647 RID: 42567 RVA: 0x0029D780 File Offset: 0x0029B980
		// (set) Token: 0x0600A648 RID: 42568 RVA: 0x00051A58 File Offset: 0x0004FC58
		public unsafe TextMeshProUGUI DescriptionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_DescriptionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_DescriptionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006F84 RID: 28548
		private static readonly IntPtr NativeFieldInfoPtr_Height;

		// Token: 0x04006F85 RID: 28549
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04006F86 RID: 28550
		private static readonly IntPtr NativeFieldInfoPtr_DescriptionLabel;

		// Token: 0x04006F87 RID: 28551
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04006F88 RID: 28552
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemDefinition_0;

		// Token: 0x04006F89 RID: 28553
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
