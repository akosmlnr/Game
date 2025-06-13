using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200029C RID: 668
	[Serializable]
	public class PotConfigurationData : SaveData
	{
		// Token: 0x06003112 RID: 12562 RVA: 0x00110374 File Offset: 0x0010E574
		// Note: this type is marked as 'beforefieldinit'.
		static PotConfigurationData()
		{
			Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PotConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr);
			PotConfigurationData.NativeFieldInfoPtr_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, "Seed");
			PotConfigurationData.NativeFieldInfoPtr_Additive1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, "Additive1");
			PotConfigurationData.NativeFieldInfoPtr_Additive2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, "Additive2");
			PotConfigurationData.NativeFieldInfoPtr_Additive3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, "Additive3");
			PotConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, "Destination");
			PotConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ItemFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, 100669033);
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x0011041C File Offset: 0x0010E61C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136821, RefRangeEnd = 136822, XrefRangeStart = 136815, XrefRangeEnd = 136821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotConfigurationData(ItemFieldData seed, ItemFieldData additive1, ItemFieldData additive2, ItemFieldData additive3, ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(seed);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additive1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additive2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additive3);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ItemFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x00019BF8 File Offset: 0x00017DF8
		public PotConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06003115 RID: 12565 RVA: 0x001104B4 File Offset: 0x0010E6B4
		// (set) Token: 0x06003116 RID: 12566 RVA: 0x00019C01 File Offset: 0x00017E01
		public unsafe ItemFieldData Seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Seed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Seed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x06003117 RID: 12567 RVA: 0x001104E4 File Offset: 0x0010E6E4
		// (set) Token: 0x06003118 RID: 12568 RVA: 0x00019C20 File Offset: 0x00017E20
		public unsafe ItemFieldData Additive1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x06003119 RID: 12569 RVA: 0x00110514 File Offset: 0x0010E714
		// (set) Token: 0x0600311A RID: 12570 RVA: 0x00019C3F File Offset: 0x00017E3F
		public unsafe ItemFieldData Additive2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x0600311B RID: 12571 RVA: 0x00110544 File Offset: 0x0010E744
		// (set) Token: 0x0600311C RID: 12572 RVA: 0x00019C5E File Offset: 0x00017E5E
		public unsafe ItemFieldData Additive3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x0600311D RID: 12573 RVA: 0x00110574 File Offset: 0x0010E774
		// (set) Token: 0x0600311E RID: 12574 RVA: 0x00019C7D File Offset: 0x00017E7D
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002044 RID: 8260
		private static readonly IntPtr NativeFieldInfoPtr_Seed;

		// Token: 0x04002045 RID: 8261
		private static readonly IntPtr NativeFieldInfoPtr_Additive1;

		// Token: 0x04002046 RID: 8262
		private static readonly IntPtr NativeFieldInfoPtr_Additive2;

		// Token: 0x04002047 RID: 8263
		private static readonly IntPtr NativeFieldInfoPtr_Additive3;

		// Token: 0x04002048 RID: 8264
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04002049 RID: 8265
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ObjectFieldData_0;
	}
}
