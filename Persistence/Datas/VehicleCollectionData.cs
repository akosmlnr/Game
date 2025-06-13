using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002DD RID: 733
	[Serializable]
	public class VehicleCollectionData : SaveData
	{
		// Token: 0x06003368 RID: 13160 RVA: 0x00116E70 File Offset: 0x00115070
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleCollectionData()
		{
			Il2CppClassPointerStore<VehicleCollectionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "VehicleCollectionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleCollectionData>.NativeClassPtr);
			VehicleCollectionData.NativeFieldInfoPtr_Vehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCollectionData>.NativeClassPtr, "Vehicles");
			VehicleCollectionData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_VehicleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCollectionData>.NativeClassPtr, 100669107);
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x00116EC8 File Offset: 0x001150C8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 136201, RefRangeEnd = 136212, XrefRangeStart = 136201, XrefRangeEnd = 136212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleCollectionData(Il2CppReferenceArray<VehicleData> vehicles) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleCollectionData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicles);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCollectionData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_VehicleData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x0001B513 File Offset: 0x00019713
		public VehicleCollectionData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x0600336B RID: 13163 RVA: 0x00116F14 File Offset: 0x00115114
		// (set) Token: 0x0600336C RID: 13164 RVA: 0x0001B51C File Offset: 0x0001971C
		public unsafe Il2CppReferenceArray<VehicleData> Vehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCollectionData.NativeFieldInfoPtr_Vehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VehicleData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCollectionData.NativeFieldInfoPtr_Vehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002153 RID: 8531
		private static readonly IntPtr NativeFieldInfoPtr_Vehicles;

		// Token: 0x04002154 RID: 8532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_VehicleData_0;
	}
}
