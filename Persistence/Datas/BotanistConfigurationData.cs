using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200028C RID: 652
	[Serializable]
	public class BotanistConfigurationData : SaveData
	{
		// Token: 0x060030B0 RID: 12464 RVA: 0x0010F348 File Offset: 0x0010D548
		// Note: this type is marked as 'beforefieldinit'.
		static BotanistConfigurationData()
		{
			Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "BotanistConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr);
			BotanistConfigurationData.NativeFieldInfoPtr_Bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr, "Bed");
			BotanistConfigurationData.NativeFieldInfoPtr_Supplies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr, "Supplies");
			BotanistConfigurationData.NativeFieldInfoPtr_Pots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr, "Pots");
			BotanistConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectFieldData_ObjectListFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr, 100669017);
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x0010F3C8 File Offset: 0x0010D5C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 136668, RefRangeEnd = 136671, XrefRangeStart = 136664, XrefRangeEnd = 136668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BotanistConfigurationData(ObjectFieldData bed, ObjectFieldData supplies, ObjectListFieldData pots) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bed);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(supplies);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pots);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectFieldData_ObjectListFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x00019865 File Offset: 0x00017A65
		public BotanistConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x060030B3 RID: 12467 RVA: 0x0010F438 File Offset: 0x0010D638
		// (set) Token: 0x060030B4 RID: 12468 RVA: 0x0001986E File Offset: 0x00017A6E
		public unsafe ObjectFieldData Bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x060030B5 RID: 12469 RVA: 0x0010F468 File Offset: 0x0010D668
		// (set) Token: 0x060030B6 RID: 12470 RVA: 0x0001988D File Offset: 0x00017A8D
		public unsafe ObjectFieldData Supplies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Supplies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Supplies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x060030B7 RID: 12471 RVA: 0x0010F498 File Offset: 0x0010D698
		// (set) Token: 0x060030B8 RID: 12472 RVA: 0x000198AC File Offset: 0x00017AAC
		public unsafe ObjectListFieldData Pots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Pots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Pots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400201B RID: 8219
		private static readonly IntPtr NativeFieldInfoPtr_Bed;

		// Token: 0x0400201C RID: 8220
		private static readonly IntPtr NativeFieldInfoPtr_Supplies;

		// Token: 0x0400201D RID: 8221
		private static readonly IntPtr NativeFieldInfoPtr_Pots;

		// Token: 0x0400201E RID: 8222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectFieldData_ObjectListFieldData_0;
	}
}
