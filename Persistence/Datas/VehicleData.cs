using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles.Modification;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002DE RID: 734
	[System.Serializable]
	public class VehicleData : SaveData
	{
		// Token: 0x0600336D RID: 13165 RVA: 0x00116F44 File Offset: 0x00115144
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleData()
		{
			Il2CppClassPointerStore<VehicleData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "VehicleData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleData>.NativeClassPtr);
			VehicleData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "GUID");
			VehicleData.NativeFieldInfoPtr_VehicleCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "VehicleCode");
			VehicleData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "Position");
			VehicleData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "Rotation");
			VehicleData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "Color");
			VehicleData.NativeFieldInfoPtr_VehicleContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "VehicleContents");
			VehicleData.NativeMethodInfoPtr__ctor_Public_Void_Guid_String_Vector3_Quaternion_EVehicleColor_ItemSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, 100669108);
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x00117000 File Offset: 0x00115200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137288, RefRangeEnd = 137289, XrefRangeStart = 137279, XrefRangeEnd = 137288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleData(Il2CppSystem.Guid guid, string code, Vector3 pos, Quaternion rot, EVehicleColor col, ItemSet vehicleContents) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref pos;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rot;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref col;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicleContents);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleData.NativeMethodInfoPtr__ctor_Public_Void_Guid_String_Vector3_Quaternion_EVehicleColor_ItemSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x0001B53B File Offset: 0x0001973B
		public VehicleData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x06003370 RID: 13168 RVA: 0x00117098 File Offset: 0x00115298
		// (set) Token: 0x06003371 RID: 13169 RVA: 0x0001B544 File Offset: 0x00019744
		public unsafe string GUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x06003372 RID: 13170 RVA: 0x001170C0 File Offset: 0x001152C0
		// (set) Token: 0x06003373 RID: 13171 RVA: 0x0001B563 File Offset: 0x00019763
		public unsafe string VehicleCode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_VehicleCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_VehicleCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x06003374 RID: 13172 RVA: 0x001170E8 File Offset: 0x001152E8
		// (set) Token: 0x06003375 RID: 13173 RVA: 0x0001B582 File Offset: 0x00019782
		public unsafe Vector3 Position
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x06003376 RID: 13174 RVA: 0x00117110 File Offset: 0x00115310
		// (set) Token: 0x06003377 RID: 13175 RVA: 0x0001B59D File Offset: 0x0001979D
		public unsafe Quaternion Rotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x06003378 RID: 13176 RVA: 0x00117138 File Offset: 0x00115338
		// (set) Token: 0x06003379 RID: 13177 RVA: 0x0001B5B8 File Offset: 0x000197B8
		public unsafe string Color
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Color);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Color), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x0600337A RID: 13178 RVA: 0x00117160 File Offset: 0x00115360
		// (set) Token: 0x0600337B RID: 13179 RVA: 0x0001B5D7 File Offset: 0x000197D7
		public unsafe ItemSet VehicleContents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_VehicleContents);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_VehicleContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002155 RID: 8533
		private static readonly System.IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04002156 RID: 8534
		private static readonly System.IntPtr NativeFieldInfoPtr_VehicleCode;

		// Token: 0x04002157 RID: 8535
		private static readonly System.IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04002158 RID: 8536
		private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x04002159 RID: 8537
		private static readonly System.IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x0400215A RID: 8538
		private static readonly System.IntPtr NativeFieldInfoPtr_VehicleContents;

		// Token: 0x0400215B RID: 8539
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_String_Vector3_Quaternion_EVehicleColor_ItemSet_0;
	}
}
