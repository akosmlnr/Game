using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000280 RID: 640
	[Serializable]
	public class ItemData : SaveData
	{
		// Token: 0x0600306B RID: 12395 RVA: 0x0010E7E8 File Offset: 0x0010C9E8
		// Note: this type is marked as 'beforefieldinit'.
		static ItemData()
		{
			Il2CppClassPointerStore<ItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemData>.NativeClassPtr);
			ItemData.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "ID");
			ItemData.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "Quantity");
			ItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100669004);
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x0010E854 File Offset: 0x0010CA54
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 136648, RefRangeEnd = 136653, XrefRangeStart = 136646, XrefRangeEnd = 136648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemData(string iD, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x00019582 File Offset: 0x00017782
		public ItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x0600306E RID: 12398 RVA: 0x0010E8B0 File Offset: 0x0010CAB0
		// (set) Token: 0x0600306F RID: 12399 RVA: 0x0001958B File Offset: 0x0001778B
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemData.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemData.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x06003070 RID: 12400 RVA: 0x0010E8D8 File Offset: 0x0010CAD8
		// (set) Token: 0x06003071 RID: 12401 RVA: 0x000195AA File Offset: 0x000177AA
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemData.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemData.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x04001FFE RID: 8190
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04001FFF RID: 8191
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x04002000 RID: 8192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;
	}
}
