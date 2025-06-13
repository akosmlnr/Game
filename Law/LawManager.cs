using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Police;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003F9 RID: 1017
	public class LawManager : Singleton<LawManager>
	{
		// Token: 0x06004DA6 RID: 19878 RVA: 0x0017754C File Offset: 0x0017574C
		// Note: this type is marked as 'beforefieldinit'.
		static LawManager()
		{
			Il2CppClassPointerStore<LawManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "LawManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LawManager>.NativeClassPtr);
			LawManager.NativeFieldInfoPtr_DISPATCH_OFFICER_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawManager>.NativeClassPtr, "DISPATCH_OFFICER_COUNT");
			LawManager.NativeFieldInfoPtr_DISPATCH_VEHICLE_USE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawManager>.NativeClassPtr, "DISPATCH_VEHICLE_USE_THRESHOLD");
			LawManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager>.NativeClassPtr, 100672981);
			LawManager.NativeMethodInfoPtr_PoliceCalled_Public_Void_Player_Crime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager>.NativeClassPtr, 100672982);
			LawManager.NativeMethodInfoPtr_StartFootpatrol_Public_PatrolGroup_FootPatrolRoute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager>.NativeClassPtr, 100672983);
			LawManager.NativeMethodInfoPtr_StartVehiclePatrol_Public_PoliceOfficer_VehiclePatrolRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager>.NativeClassPtr, 100672984);
			LawManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager>.NativeClassPtr, 100672985);
		}

		// Token: 0x06004DA7 RID: 19879 RVA: 0x00177608 File Offset: 0x00175808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169836, XrefRangeEnd = 169862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004DA8 RID: 19880 RVA: 0x00177644 File Offset: 0x00175844
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 169882, RefRangeEnd = 169885, XrefRangeStart = 169862, XrefRangeEnd = 169882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PoliceCalled(Player target, Crime crime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(crime);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.NativeMethodInfoPtr_PoliceCalled_Public_Void_Player_Crime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004DA9 RID: 19881 RVA: 0x00177698 File Offset: 0x00175898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169913, RefRangeEnd = 169914, XrefRangeStart = 169885, XrefRangeEnd = 169913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PatrolGroup StartFootpatrol(FootPatrolRoute route, int requestedMembers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref requestedMembers;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.NativeMethodInfoPtr_StartFootpatrol_Public_PatrolGroup_FootPatrolRoute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PatrolGroup>(intPtr2) : null;
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x001776F8 File Offset: 0x001758F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169926, RefRangeEnd = 169928, XrefRangeStart = 169914, XrefRangeEnd = 169926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceOfficer StartVehiclePatrol(VehiclePatrolRoute route)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.NativeMethodInfoPtr_StartVehiclePatrol_Public_PoliceOfficer_VehiclePatrolRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
		}

		// Token: 0x06004DAB RID: 19883 RVA: 0x00177748 File Offset: 0x00175948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169928, XrefRangeEnd = 169931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LawManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LawManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004DAC RID: 19884 RVA: 0x00025283 File Offset: 0x00023483
		public LawManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x06004DAD RID: 19885 RVA: 0x00177784 File Offset: 0x00175984
		// (set) Token: 0x06004DAE RID: 19886 RVA: 0x0002528C File Offset: 0x0002348C
		public unsafe static int DISPATCH_OFFICER_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LawManager.NativeFieldInfoPtr_DISPATCH_OFFICER_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LawManager.NativeFieldInfoPtr_DISPATCH_OFFICER_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x06004DAF RID: 19887 RVA: 0x001777A0 File Offset: 0x001759A0
		// (set) Token: 0x06004DB0 RID: 19888 RVA: 0x0002529A File Offset: 0x0002349A
		public unsafe static float DISPATCH_VEHICLE_USE_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LawManager.NativeFieldInfoPtr_DISPATCH_VEHICLE_USE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LawManager.NativeFieldInfoPtr_DISPATCH_VEHICLE_USE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x04003451 RID: 13393
		private static readonly System.IntPtr NativeFieldInfoPtr_DISPATCH_OFFICER_COUNT;

		// Token: 0x04003452 RID: 13394
		private static readonly System.IntPtr NativeFieldInfoPtr_DISPATCH_VEHICLE_USE_THRESHOLD;

		// Token: 0x04003453 RID: 13395
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003454 RID: 13396
		private static readonly System.IntPtr NativeMethodInfoPtr_PoliceCalled_Public_Void_Player_Crime_0;

		// Token: 0x04003455 RID: 13397
		private static readonly System.IntPtr NativeMethodInfoPtr_StartFootpatrol_Public_PatrolGroup_FootPatrolRoute_Int32_0;

		// Token: 0x04003456 RID: 13398
		private static readonly System.IntPtr NativeMethodInfoPtr_StartVehiclePatrol_Public_PoliceOfficer_VehiclePatrolRoute_0;

		// Token: 0x04003457 RID: 13399
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009D5 RID: 2517
		[ObfuscatedName("ScheduleOne.Law.LawManager+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CF67 RID: 53095 RVA: 0x0032473C File Offset: 0x0032293C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LawManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr);
				LawManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr, "<>9");
				LawManager.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr, "<>9__2_0");
				LawManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr, 100672988);
				LawManager.__c.NativeMethodInfoPtr__Start_b__2_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr, 100672989);
			}

			// Token: 0x0600CF68 RID: 53096 RVA: 0x003247B8 File Offset: 0x003229B8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF69 RID: 53097 RVA: 0x003247F4 File Offset: 0x003229F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169830, XrefRangeEnd = 169836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__2_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.__c.NativeMethodInfoPtr__Start_b__2_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF6A RID: 53098 RVA: 0x00064863 File Offset: 0x00062A63
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004050 RID: 16464
			// (get) Token: 0x0600CF6B RID: 53099 RVA: 0x00324828 File Offset: 0x00322A28
			// (set) Token: 0x0600CF6C RID: 53100 RVA: 0x0006486C File Offset: 0x00062A6C
			public unsafe static LawManager.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LawManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LawManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004051 RID: 16465
			// (get) Token: 0x0600CF6D RID: 53101 RVA: 0x00324850 File Offset: 0x00322A50
			// (set) Token: 0x0600CF6E RID: 53102 RVA: 0x0006487E File Offset: 0x00062A7E
			public unsafe static UnityAction __9__2_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LawManager.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LawManager.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C59 RID: 35929
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008C5A RID: 35930
			private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04008C5B RID: 35931
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C5C RID: 35932
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__2_0_Internal_Void_0;
		}
	}
}
