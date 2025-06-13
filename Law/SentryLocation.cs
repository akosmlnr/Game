using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Police;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003FD RID: 1021
	public class SentryLocation : MonoBehaviour
	{
		// Token: 0x06004DFC RID: 19964 RVA: 0x00178238 File Offset: 0x00176438
		// Note: this type is marked as 'beforefieldinit'.
		static SentryLocation()
		{
			Il2CppClassPointerStore<SentryLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "SentryLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr);
			SentryLocation.NativeFieldInfoPtr_StandPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr, "StandPoints");
			SentryLocation.NativeFieldInfoPtr_AssignedOfficers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr, "AssignedOfficers");
			SentryLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr, 100673003);
		}

		// Token: 0x06004DFD RID: 19965 RVA: 0x001782A4 File Offset: 0x001764A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170214, XrefRangeEnd = 170229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SentryLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004DFE RID: 19966 RVA: 0x00025511 File Offset: 0x00023711
		public SentryLocation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x06004DFF RID: 19967 RVA: 0x001782E0 File Offset: 0x001764E0
		// (set) Token: 0x06004E00 RID: 19968 RVA: 0x0002551A File Offset: 0x0002371A
		public unsafe List<Transform> StandPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryLocation.NativeFieldInfoPtr_StandPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryLocation.NativeFieldInfoPtr_StandPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x06004E01 RID: 19969 RVA: 0x00178310 File Offset: 0x00176510
		// (set) Token: 0x06004E02 RID: 19970 RVA: 0x00025539 File Offset: 0x00023739
		public unsafe List<PoliceOfficer> AssignedOfficers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryLocation.NativeFieldInfoPtr_AssignedOfficers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryLocation.NativeFieldInfoPtr_AssignedOfficers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003481 RID: 13441
		private static readonly IntPtr NativeFieldInfoPtr_StandPoints;

		// Token: 0x04003482 RID: 13442
		private static readonly IntPtr NativeFieldInfoPtr_AssignedOfficers;

		// Token: 0x04003483 RID: 13443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
