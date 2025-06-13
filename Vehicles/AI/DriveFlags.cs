using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x0200051E RID: 1310
	[System.Serializable]
	public class DriveFlags : Il2CppSystem.Object
	{
		// Token: 0x060072B1 RID: 29361 RVA: 0x001F9DE8 File Offset: 0x001F7FE8
		// Note: this type is marked as 'beforefieldinit'.
		static DriveFlags()
		{
			Il2CppClassPointerStore<DriveFlags>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "DriveFlags");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr);
			DriveFlags.NativeFieldInfoPtr_OverrideSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "OverrideSpeed");
			DriveFlags.NativeFieldInfoPtr_OverriddenSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "OverriddenSpeed");
			DriveFlags.NativeFieldInfoPtr_OverriddenReverseSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "OverriddenReverseSpeed");
			DriveFlags.NativeFieldInfoPtr_SpeedLimitMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "SpeedLimitMultiplier");
			DriveFlags.NativeFieldInfoPtr_IgnoreTrafficLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "IgnoreTrafficLights");
			DriveFlags.NativeFieldInfoPtr_UseRoads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "UseRoads");
			DriveFlags.NativeFieldInfoPtr_StuckDetection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "StuckDetection");
			DriveFlags.NativeFieldInfoPtr_ObstacleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "ObstacleMode");
			DriveFlags.NativeFieldInfoPtr_AutoBrakeAtDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "AutoBrakeAtDestination");
			DriveFlags.NativeFieldInfoPtr_TurnBasedSpeedReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "TurnBasedSpeedReduction");
			DriveFlags.NativeMethodInfoPtr_ResetFlags_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, 100677802);
			DriveFlags.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, 100677803);
		}

		// Token: 0x060072B2 RID: 29362 RVA: 0x001F9F08 File Offset: 0x001F8108
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 225803, RefRangeEnd = 225806, XrefRangeStart = 225803, XrefRangeEnd = 225803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DriveFlags.NativeMethodInfoPtr_ResetFlags_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060072B3 RID: 29363 RVA: 0x001F9F3C File Offset: 0x001F813C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225806, XrefRangeEnd = 225807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DriveFlags() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DriveFlags.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060072B4 RID: 29364 RVA: 0x00036361 File Offset: 0x00034561
		public DriveFlags(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002279 RID: 8825
		// (get) Token: 0x060072B5 RID: 29365 RVA: 0x001F9F78 File Offset: 0x001F8178
		// (set) Token: 0x060072B6 RID: 29366 RVA: 0x0003636A File Offset: 0x0003456A
		public unsafe bool OverrideSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverrideSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverrideSpeed)) = value;
			}
		}

		// Token: 0x1700227A RID: 8826
		// (get) Token: 0x060072B7 RID: 29367 RVA: 0x001F9FA0 File Offset: 0x001F81A0
		// (set) Token: 0x060072B8 RID: 29368 RVA: 0x00036385 File Offset: 0x00034585
		public unsafe float OverriddenSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverriddenSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverriddenSpeed)) = value;
			}
		}

		// Token: 0x1700227B RID: 8827
		// (get) Token: 0x060072B9 RID: 29369 RVA: 0x001F9FC8 File Offset: 0x001F81C8
		// (set) Token: 0x060072BA RID: 29370 RVA: 0x000363A0 File Offset: 0x000345A0
		public unsafe float OverriddenReverseSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverriddenReverseSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverriddenReverseSpeed)) = value;
			}
		}

		// Token: 0x1700227C RID: 8828
		// (get) Token: 0x060072BB RID: 29371 RVA: 0x001F9FF0 File Offset: 0x001F81F0
		// (set) Token: 0x060072BC RID: 29372 RVA: 0x000363BB File Offset: 0x000345BB
		public unsafe float SpeedLimitMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_SpeedLimitMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_SpeedLimitMultiplier)) = value;
			}
		}

		// Token: 0x1700227D RID: 8829
		// (get) Token: 0x060072BD RID: 29373 RVA: 0x001FA018 File Offset: 0x001F8218
		// (set) Token: 0x060072BE RID: 29374 RVA: 0x000363D6 File Offset: 0x000345D6
		public unsafe bool IgnoreTrafficLights
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_IgnoreTrafficLights);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_IgnoreTrafficLights)) = value;
			}
		}

		// Token: 0x1700227E RID: 8830
		// (get) Token: 0x060072BF RID: 29375 RVA: 0x001FA040 File Offset: 0x001F8240
		// (set) Token: 0x060072C0 RID: 29376 RVA: 0x000363F1 File Offset: 0x000345F1
		public unsafe bool UseRoads
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_UseRoads);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_UseRoads)) = value;
			}
		}

		// Token: 0x1700227F RID: 8831
		// (get) Token: 0x060072C1 RID: 29377 RVA: 0x001FA068 File Offset: 0x001F8268
		// (set) Token: 0x060072C2 RID: 29378 RVA: 0x0003640C File Offset: 0x0003460C
		public unsafe bool StuckDetection
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_StuckDetection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_StuckDetection)) = value;
			}
		}

		// Token: 0x17002280 RID: 8832
		// (get) Token: 0x060072C3 RID: 29379 RVA: 0x001FA090 File Offset: 0x001F8290
		// (set) Token: 0x060072C4 RID: 29380 RVA: 0x00036427 File Offset: 0x00034627
		public unsafe DriveFlags.EObstacleMode ObstacleMode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_ObstacleMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_ObstacleMode)) = value;
			}
		}

		// Token: 0x17002281 RID: 8833
		// (get) Token: 0x060072C5 RID: 29381 RVA: 0x001FA0B8 File Offset: 0x001F82B8
		// (set) Token: 0x060072C6 RID: 29382 RVA: 0x00036442 File Offset: 0x00034642
		public unsafe bool AutoBrakeAtDestination
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_AutoBrakeAtDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_AutoBrakeAtDestination)) = value;
			}
		}

		// Token: 0x17002282 RID: 8834
		// (get) Token: 0x060072C7 RID: 29383 RVA: 0x001FA0E0 File Offset: 0x001F82E0
		// (set) Token: 0x060072C8 RID: 29384 RVA: 0x0003645D File Offset: 0x0003465D
		public unsafe bool TurnBasedSpeedReduction
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_TurnBasedSpeedReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_TurnBasedSpeedReduction)) = value;
			}
		}

		// Token: 0x04004E63 RID: 20067
		private static readonly System.IntPtr NativeFieldInfoPtr_OverrideSpeed;

		// Token: 0x04004E64 RID: 20068
		private static readonly System.IntPtr NativeFieldInfoPtr_OverriddenSpeed;

		// Token: 0x04004E65 RID: 20069
		private static readonly System.IntPtr NativeFieldInfoPtr_OverriddenReverseSpeed;

		// Token: 0x04004E66 RID: 20070
		private static readonly System.IntPtr NativeFieldInfoPtr_SpeedLimitMultiplier;

		// Token: 0x04004E67 RID: 20071
		private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreTrafficLights;

		// Token: 0x04004E68 RID: 20072
		private static readonly System.IntPtr NativeFieldInfoPtr_UseRoads;

		// Token: 0x04004E69 RID: 20073
		private static readonly System.IntPtr NativeFieldInfoPtr_StuckDetection;

		// Token: 0x04004E6A RID: 20074
		private static readonly System.IntPtr NativeFieldInfoPtr_ObstacleMode;

		// Token: 0x04004E6B RID: 20075
		private static readonly System.IntPtr NativeFieldInfoPtr_AutoBrakeAtDestination;

		// Token: 0x04004E6C RID: 20076
		private static readonly System.IntPtr NativeFieldInfoPtr_TurnBasedSpeedReduction;

		// Token: 0x04004E6D RID: 20077
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetFlags_Public_Void_0;

		// Token: 0x04004E6E RID: 20078
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000ABD RID: 2749
		[OriginalName("Assembly-CSharp.dll", "", "EObstacleMode")]
		public enum EObstacleMode
		{
			// Token: 0x040090B6 RID: 37046
			Default,
			// Token: 0x040090B7 RID: 37047
			IgnoreAll,
			// Token: 0x040090B8 RID: 37048
			IgnoreOnlySquishy
		}
	}
}
