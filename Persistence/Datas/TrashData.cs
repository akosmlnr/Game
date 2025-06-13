using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002D8 RID: 728
	[Serializable]
	public class TrashData : SaveData
	{
		// Token: 0x0600333E RID: 13118 RVA: 0x001167B0 File Offset: 0x001149B0
		// Note: this type is marked as 'beforefieldinit'.
		static TrashData()
		{
			Il2CppClassPointerStore<TrashData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TrashData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashData>.NativeClassPtr);
			TrashData.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashData>.NativeClassPtr, "Items");
			TrashData.NativeFieldInfoPtr_Generators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashData>.NativeClassPtr, "Generators");
			TrashData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TrashItemData_Il2CppReferenceArray_1_TrashGeneratorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashData>.NativeClassPtr, 100669101);
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x0011681C File Offset: 0x00114A1C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 136250, RefRangeEnd = 136261, XrefRangeStart = 136250, XrefRangeEnd = 136261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashData(Il2CppReferenceArray<TrashItemData> trash, Il2CppReferenceArray<TrashGeneratorData> generators) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trash);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generators);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TrashItemData_Il2CppReferenceArray_1_TrashGeneratorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x0001B35B File Offset: 0x0001955B
		public TrashData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x06003341 RID: 13121 RVA: 0x0011687C File Offset: 0x00114A7C
		// (set) Token: 0x06003342 RID: 13122 RVA: 0x0001B364 File Offset: 0x00019564
		public unsafe Il2CppReferenceArray<TrashItemData> Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashData.NativeFieldInfoPtr_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrashItemData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashData.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x06003343 RID: 13123 RVA: 0x001168AC File Offset: 0x00114AAC
		// (set) Token: 0x06003344 RID: 13124 RVA: 0x0001B383 File Offset: 0x00019583
		public unsafe Il2CppReferenceArray<TrashGeneratorData> Generators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashData.NativeFieldInfoPtr_Generators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrashGeneratorData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashData.NativeFieldInfoPtr_Generators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002140 RID: 8512
		private static readonly IntPtr NativeFieldInfoPtr_Items;

		// Token: 0x04002141 RID: 8513
		private static readonly IntPtr NativeFieldInfoPtr_Generators;

		// Token: 0x04002142 RID: 8514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TrashItemData_Il2CppReferenceArray_1_TrashGeneratorData_0;
	}
}
