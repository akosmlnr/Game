using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020007A2 RID: 1954
	public class Dealership : MonoBehaviour
	{
		// Token: 0x0600B927 RID: 47399 RVA: 0x002E3824 File Offset: 0x002E1A24
		// Note: this type is marked as 'beforefieldinit'.
		static Dealership()
		{
			Il2CppClassPointerStore<Dealership>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "Dealership");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealership>.NativeClassPtr);
			Dealership.NativeFieldInfoPtr_SpawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealership>.NativeClassPtr, "SpawnPoints");
			Dealership.NativeMethodInfoPtr_SpawnVehicle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealership>.NativeClassPtr, 100686224);
			Dealership.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealership>.NativeClassPtr, 100686225);
		}

		// Token: 0x0600B928 RID: 47400 RVA: 0x002E3890 File Offset: 0x002E1A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316167, XrefRangeEnd = 316175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnVehicle(string vehicleCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(vehicleCode);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealership.NativeMethodInfoPtr_SpawnVehicle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B929 RID: 47401 RVA: 0x002E38D4 File Offset: 0x002E1AD4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dealership() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealership>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealership.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B92A RID: 47402 RVA: 0x0005A765 File Offset: 0x00058965
		public Dealership(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003919 RID: 14617
		// (get) Token: 0x0600B92B RID: 47403 RVA: 0x002E3910 File Offset: 0x002E1B10
		// (set) Token: 0x0600B92C RID: 47404 RVA: 0x0005A76E File Offset: 0x0005896E
		public unsafe Il2CppReferenceArray<Transform> SpawnPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealership.NativeFieldInfoPtr_SpawnPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealership.NativeFieldInfoPtr_SpawnPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007CEB RID: 31979
		private static readonly IntPtr NativeFieldInfoPtr_SpawnPoints;

		// Token: 0x04007CEC RID: 31980
		private static readonly IntPtr NativeMethodInfoPtr_SpawnVehicle_Public_Void_String_0;

		// Token: 0x04007CED RID: 31981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
