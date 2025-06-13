using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020007AA RID: 1962
	public class MedicalCentre : NPCEnterableBuilding
	{
		// Token: 0x0600B9AC RID: 47532 RVA: 0x002E4F34 File Offset: 0x002E3134
		// Note: this type is marked as 'beforefieldinit'.
		static MedicalCentre()
		{
			Il2CppClassPointerStore<MedicalCentre>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "MedicalCentre");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MedicalCentre>.NativeClassPtr);
			MedicalCentre.NativeFieldInfoPtr_RespawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MedicalCentre>.NativeClassPtr, "RespawnPoint");
			MedicalCentre.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MedicalCentre>.NativeClassPtr, 100686268);
		}

		// Token: 0x0600B9AD RID: 47533 RVA: 0x002E4F8C File Offset: 0x002E318C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316497, XrefRangeEnd = 316498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MedicalCentre() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MedicalCentre>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MedicalCentre.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9AE RID: 47534 RVA: 0x0005AC3D File Offset: 0x00058E3D
		public MedicalCentre(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003945 RID: 14661
		// (get) Token: 0x0600B9AF RID: 47535 RVA: 0x002E4FC8 File Offset: 0x002E31C8
		// (set) Token: 0x0600B9B0 RID: 47536 RVA: 0x0005AC46 File Offset: 0x00058E46
		public unsafe Transform RespawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MedicalCentre.NativeFieldInfoPtr_RespawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MedicalCentre.NativeFieldInfoPtr_RespawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007D40 RID: 32064
		private static readonly IntPtr NativeFieldInfoPtr_RespawnPoint;

		// Token: 0x04007D41 RID: 32065
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
