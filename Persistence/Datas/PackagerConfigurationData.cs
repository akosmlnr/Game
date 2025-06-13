using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200029A RID: 666
	[Serializable]
	public class PackagerConfigurationData : SaveData
	{
		// Token: 0x06003104 RID: 12548 RVA: 0x00110120 File Offset: 0x0010E320
		// Note: this type is marked as 'beforefieldinit'.
		static PackagerConfigurationData()
		{
			Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PackagerConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr);
			PackagerConfigurationData.NativeFieldInfoPtr_Bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr, "Bed");
			PackagerConfigurationData.NativeFieldInfoPtr_Stations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr, "Stations");
			PackagerConfigurationData.NativeFieldInfoPtr_Routes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr, "Routes");
			PackagerConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_RouteListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr, 100669031);
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x001101A0 File Offset: 0x0010E3A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 136668, RefRangeEnd = 136671, XrefRangeStart = 136668, XrefRangeEnd = 136671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagerConfigurationData(ObjectFieldData bed, ObjectListFieldData stations, RouteListData routes) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bed);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stations);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(routes);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_RouteListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003106 RID: 12550 RVA: 0x00019B6A File Offset: 0x00017D6A
		public PackagerConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x06003107 RID: 12551 RVA: 0x00110210 File Offset: 0x0010E410
		// (set) Token: 0x06003108 RID: 12552 RVA: 0x00019B73 File Offset: 0x00017D73
		public unsafe ObjectFieldData Bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigurationData.NativeFieldInfoPtr_Bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigurationData.NativeFieldInfoPtr_Bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06003109 RID: 12553 RVA: 0x00110240 File Offset: 0x0010E440
		// (set) Token: 0x0600310A RID: 12554 RVA: 0x00019B92 File Offset: 0x00017D92
		public unsafe ObjectListFieldData Stations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigurationData.NativeFieldInfoPtr_Stations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigurationData.NativeFieldInfoPtr_Stations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x0600310B RID: 12555 RVA: 0x00110270 File Offset: 0x0010E470
		// (set) Token: 0x0600310C RID: 12556 RVA: 0x00019BB1 File Offset: 0x00017DB1
		public unsafe RouteListData Routes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigurationData.NativeFieldInfoPtr_Routes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RouteListData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigurationData.NativeFieldInfoPtr_Routes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400203E RID: 8254
		private static readonly IntPtr NativeFieldInfoPtr_Bed;

		// Token: 0x0400203F RID: 8255
		private static readonly IntPtr NativeFieldInfoPtr_Stations;

		// Token: 0x04002040 RID: 8256
		private static readonly IntPtr NativeFieldInfoPtr_Routes;

		// Token: 0x04002041 RID: 8257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_RouteListData_0;
	}
}
