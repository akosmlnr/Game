using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Clothing;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005FA RID: 1530
	public class ItemFilter_ClothingSlot : ItemFilter
	{
		// Token: 0x06008561 RID: 34145 RVA: 0x00239784 File Offset: 0x00237984
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_ClothingSlot()
		{
			Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_ClothingSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr);
			ItemFilter_ClothingSlot.NativeFieldInfoPtr__SlotType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr, "<SlotType>k__BackingField");
			ItemFilter_ClothingSlot.NativeMethodInfoPtr_get_SlotType_Public_get_EClothingSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr, 100680078);
			ItemFilter_ClothingSlot.NativeMethodInfoPtr_set_SlotType_Private_set_Void_EClothingSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr, 100680079);
			ItemFilter_ClothingSlot.NativeMethodInfoPtr__ctor_Public_Void_EClothingSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr, 100680080);
			ItemFilter_ClothingSlot.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr, 100680081);
		}

		// Token: 0x17002828 RID: 10280
		// (get) Token: 0x06008562 RID: 34146 RVA: 0x00239818 File Offset: 0x00237A18
		// (set) Token: 0x06008563 RID: 34147 RVA: 0x00239854 File Offset: 0x00237A54
		public unsafe EClothingSlot SlotType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31404, RefRangeEnd = 31405, XrefRangeStart = 31404, XrefRangeEnd = 31405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemFilter_ClothingSlot.NativeMethodInfoPtr_get_SlotType_Public_get_EClothingSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 31405, RefRangeEnd = 31411, XrefRangeStart = 31405, XrefRangeEnd = 31411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_ClothingSlot.NativeMethodInfoPtr_set_SlotType_Private_set_Void_EClothingSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008564 RID: 34148 RVA: 0x00239894 File Offset: 0x00237A94
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_ClothingSlot(EClothingSlot slot) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slot;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_ClothingSlot.NativeMethodInfoPtr__ctor_Public_Void_EClothingSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008565 RID: 34149 RVA: 0x002398DC File Offset: 0x00237ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250843, XrefRangeEnd = 250852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_ClothingSlot.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008566 RID: 34150 RVA: 0x0003F1EE File Offset: 0x0003D3EE
		public ItemFilter_ClothingSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002827 RID: 10279
		// (get) Token: 0x06008567 RID: 34151 RVA: 0x00239934 File Offset: 0x00237B34
		// (set) Token: 0x06008568 RID: 34152 RVA: 0x0003F1F7 File Offset: 0x0003D3F7
		public unsafe EClothingSlot _SlotType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ClothingSlot.NativeFieldInfoPtr__SlotType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ClothingSlot.NativeFieldInfoPtr__SlotType_k__BackingField)) = value;
			}
		}

		// Token: 0x04005AD2 RID: 23250
		private static readonly IntPtr NativeFieldInfoPtr__SlotType_k__BackingField;

		// Token: 0x04005AD3 RID: 23251
		private static readonly IntPtr NativeMethodInfoPtr_get_SlotType_Public_get_EClothingSlot_0;

		// Token: 0x04005AD4 RID: 23252
		private static readonly IntPtr NativeMethodInfoPtr_set_SlotType_Private_set_Void_EClothingSlot_0;

		// Token: 0x04005AD5 RID: 23253
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EClothingSlot_0;

		// Token: 0x04005AD6 RID: 23254
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
