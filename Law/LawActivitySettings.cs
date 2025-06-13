using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003F7 RID: 1015
	[System.Serializable]
	public class LawActivitySettings : Il2CppSystem.Object
	{
		// Token: 0x06004D4F RID: 19791 RVA: 0x00176354 File Offset: 0x00174554
		// Note: this type is marked as 'beforefieldinit'.
		static LawActivitySettings()
		{
			Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "LawActivitySettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr);
			LawActivitySettings.NativeFieldInfoPtr_Patrols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, "Patrols");
			LawActivitySettings.NativeFieldInfoPtr_Checkpoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, "Checkpoints");
			LawActivitySettings.NativeFieldInfoPtr_Curfews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, "Curfews");
			LawActivitySettings.NativeFieldInfoPtr_VehiclePatrols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, "VehiclePatrols");
			LawActivitySettings.NativeFieldInfoPtr_Sentries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, "Sentries");
			LawActivitySettings.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, 100672944);
			LawActivitySettings.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, 100672945);
			LawActivitySettings.NativeMethodInfoPtr_OnLoaded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, 100672946);
			LawActivitySettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, 100672947);
		}

		// Token: 0x06004D50 RID: 19792 RVA: 0x00176438 File Offset: 0x00174638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169630, RefRangeEnd = 169631, XrefRangeStart = 169598, XrefRangeEnd = 169630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawActivitySettings.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D51 RID: 19793 RVA: 0x0017646C File Offset: 0x0017466C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169631, XrefRangeEnd = 169632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawActivitySettings.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D52 RID: 19794 RVA: 0x001764A0 File Offset: 0x001746A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169632, XrefRangeEnd = 169640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawActivitySettings.NativeMethodInfoPtr_OnLoaded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D53 RID: 19795 RVA: 0x001764D4 File Offset: 0x001746D4
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LawActivitySettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawActivitySettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D54 RID: 19796 RVA: 0x00024FCD File Offset: 0x000231CD
		public LawActivitySettings(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x06004D55 RID: 19797 RVA: 0x00176510 File Offset: 0x00174710
		// (set) Token: 0x06004D56 RID: 19798 RVA: 0x00024FD6 File Offset: 0x000231D6
		public unsafe Il2CppReferenceArray<PatrolInstance> Patrols
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Patrols);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PatrolInstance>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Patrols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x06004D57 RID: 19799 RVA: 0x00176540 File Offset: 0x00174740
		// (set) Token: 0x06004D58 RID: 19800 RVA: 0x00024FF5 File Offset: 0x000231F5
		public unsafe Il2CppReferenceArray<CheckpointInstance> Checkpoints
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Checkpoints);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CheckpointInstance>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Checkpoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x06004D59 RID: 19801 RVA: 0x00176570 File Offset: 0x00174770
		// (set) Token: 0x06004D5A RID: 19802 RVA: 0x00025014 File Offset: 0x00023214
		public unsafe Il2CppReferenceArray<CurfewInstance> Curfews
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Curfews);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CurfewInstance>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Curfews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x06004D5B RID: 19803 RVA: 0x001765A0 File Offset: 0x001747A0
		// (set) Token: 0x06004D5C RID: 19804 RVA: 0x00025033 File Offset: 0x00023233
		public unsafe Il2CppReferenceArray<VehiclePatrolInstance> VehiclePatrols
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_VehiclePatrols);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VehiclePatrolInstance>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_VehiclePatrols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x06004D5D RID: 19805 RVA: 0x001765D0 File Offset: 0x001747D0
		// (set) Token: 0x06004D5E RID: 19806 RVA: 0x00025052 File Offset: 0x00023252
		public unsafe Il2CppReferenceArray<SentryInstance> Sentries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Sentries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SentryInstance>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Sentries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003415 RID: 13333
		private static readonly System.IntPtr NativeFieldInfoPtr_Patrols;

		// Token: 0x04003416 RID: 13334
		private static readonly System.IntPtr NativeFieldInfoPtr_Checkpoints;

		// Token: 0x04003417 RID: 13335
		private static readonly System.IntPtr NativeFieldInfoPtr_Curfews;

		// Token: 0x04003418 RID: 13336
		private static readonly System.IntPtr NativeFieldInfoPtr_VehiclePatrols;

		// Token: 0x04003419 RID: 13337
		private static readonly System.IntPtr NativeFieldInfoPtr_Sentries;

		// Token: 0x0400341A RID: 13338
		private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x0400341B RID: 13339
		private static readonly System.IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x0400341C RID: 13340
		private static readonly System.IntPtr NativeMethodInfoPtr_OnLoaded_Public_Void_0;

		// Token: 0x0400341D RID: 13341
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
