using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020007AE RID: 1966
	public class OceanCollider : MonoBehaviour
	{
		// Token: 0x0600B9E1 RID: 47585 RVA: 0x002E59CC File Offset: 0x002E3BCC
		// Note: this type is marked as 'beforefieldinit'.
		static OceanCollider()
		{
			Il2CppClassPointerStore<OceanCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "OceanCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr);
			OceanCollider.NativeFieldInfoPtr_localPlayerBeingWarped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, "localPlayerBeingWarped");
			OceanCollider.NativeFieldInfoPtr_warpedVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, "warpedVehicles");
			OceanCollider.NativeFieldInfoPtr_SplashSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, "SplashSound");
			OceanCollider.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, 100686295);
			OceanCollider.NativeMethodInfoPtr_WarpPlayer_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, 100686296);
			OceanCollider.NativeMethodInfoPtr_WarpVehicle_Private_IEnumerator_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, 100686297);
			OceanCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, 100686298);
		}

		// Token: 0x0600B9E2 RID: 47586 RVA: 0x002E5A88 File Offset: 0x002E3C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316815, XrefRangeEnd = 316885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9E3 RID: 47587 RVA: 0x002E5ACC File Offset: 0x002E3CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316885, XrefRangeEnd = 316890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WarpPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider.NativeMethodInfoPtr_WarpPlayer_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600B9E4 RID: 47588 RVA: 0x002E5B0C File Offset: 0x002E3D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316890, XrefRangeEnd = 316896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WarpVehicle(LandVehicle veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider.NativeMethodInfoPtr_WarpVehicle_Private_IEnumerator_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600B9E5 RID: 47589 RVA: 0x002E5B5C File Offset: 0x002E3D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316896, XrefRangeEnd = 316904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OceanCollider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9E6 RID: 47590 RVA: 0x0005ADAB File Offset: 0x00058FAB
		public OceanCollider(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003954 RID: 14676
		// (get) Token: 0x0600B9E7 RID: 47591 RVA: 0x002E5B98 File Offset: 0x002E3D98
		// (set) Token: 0x0600B9E8 RID: 47592 RVA: 0x0005ADB4 File Offset: 0x00058FB4
		public unsafe bool localPlayerBeingWarped
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider.NativeFieldInfoPtr_localPlayerBeingWarped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider.NativeFieldInfoPtr_localPlayerBeingWarped)) = value;
			}
		}

		// Token: 0x17003955 RID: 14677
		// (get) Token: 0x0600B9E9 RID: 47593 RVA: 0x002E5BC0 File Offset: 0x002E3DC0
		// (set) Token: 0x0600B9EA RID: 47594 RVA: 0x0005ADCF File Offset: 0x00058FCF
		public unsafe List<LandVehicle> warpedVehicles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider.NativeFieldInfoPtr_warpedVehicles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider.NativeFieldInfoPtr_warpedVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003956 RID: 14678
		// (get) Token: 0x0600B9EB RID: 47595 RVA: 0x002E5BF0 File Offset: 0x002E3DF0
		// (set) Token: 0x0600B9EC RID: 47596 RVA: 0x0005ADEE File Offset: 0x00058FEE
		public unsafe AudioSourceController SplashSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider.NativeFieldInfoPtr_SplashSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider.NativeFieldInfoPtr_SplashSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007D61 RID: 32097
		private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerBeingWarped;

		// Token: 0x04007D62 RID: 32098
		private static readonly System.IntPtr NativeFieldInfoPtr_warpedVehicles;

		// Token: 0x04007D63 RID: 32099
		private static readonly System.IntPtr NativeFieldInfoPtr_SplashSound;

		// Token: 0x04007D64 RID: 32100
		private static readonly System.IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x04007D65 RID: 32101
		private static readonly System.IntPtr NativeMethodInfoPtr_WarpPlayer_Private_IEnumerator_0;

		// Token: 0x04007D66 RID: 32102
		private static readonly System.IntPtr NativeMethodInfoPtr_WarpVehicle_Private_IEnumerator_LandVehicle_0;

		// Token: 0x04007D67 RID: 32103
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C5B RID: 3163
		[ObfuscatedName("ScheduleOne.Map.OceanCollider+<WarpPlayer>d__4")]
		public sealed class _WarpPlayer_d__4 : Il2CppSystem.Object
		{
			// Token: 0x0600E591 RID: 58769 RVA: 0x00362F9C File Offset: 0x0036119C
			// Note: this type is marked as 'beforefieldinit'.
			static _WarpPlayer_d__4()
			{
				Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, "<WarpPlayer>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr);
				OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, "<>1__state");
				OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, "<>2__current");
				OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, "<>4__this");
				OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, 100686299);
				OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, 100686300);
				OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, 100686301);
				OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, 100686302);
				OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, 100686303);
				OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, 100686304);
			}

			// Token: 0x0600E592 RID: 58770 RVA: 0x0036307C File Offset: 0x0036127C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WarpPlayer_d__4(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E593 RID: 58771 RVA: 0x003630C4 File Offset: 0x003612C4
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E594 RID: 58772 RVA: 0x003630F8 File Offset: 0x003612F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316757, XrefRangeEnd = 316763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170046D3 RID: 18131
			// (get) Token: 0x0600E595 RID: 58773 RVA: 0x00363134 File Offset: 0x00361334
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E596 RID: 58774 RVA: 0x00363174 File Offset: 0x00361374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316763, XrefRangeEnd = 316768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170046D4 RID: 18132
			// (get) Token: 0x0600E597 RID: 58775 RVA: 0x003631A8 File Offset: 0x003613A8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E598 RID: 58776 RVA: 0x0006F9FC File Offset: 0x0006DBFC
			public _WarpPlayer_d__4(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046D0 RID: 18128
			// (get) Token: 0x0600E599 RID: 58777 RVA: 0x003631E8 File Offset: 0x003613E8
			// (set) Token: 0x0600E59A RID: 58778 RVA: 0x0006FA05 File Offset: 0x0006DC05
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170046D1 RID: 18129
			// (get) Token: 0x0600E59B RID: 58779 RVA: 0x00363210 File Offset: 0x00361410
			// (set) Token: 0x0600E59C RID: 58780 RVA: 0x0006FA20 File Offset: 0x0006DC20
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046D2 RID: 18130
			// (get) Token: 0x0600E59D RID: 58781 RVA: 0x00363240 File Offset: 0x00361440
			// (set) Token: 0x0600E59E RID: 58782 RVA: 0x0006FA3F File Offset: 0x0006DC3F
			public unsafe OceanCollider __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OceanCollider>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099C4 RID: 39364
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040099C5 RID: 39365
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040099C6 RID: 39366
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040099C7 RID: 39367
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040099C8 RID: 39368
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040099C9 RID: 39369
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040099CA RID: 39370
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040099CB RID: 39371
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040099CC RID: 39372
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C5C RID: 3164
		[ObfuscatedName("ScheduleOne.Map.OceanCollider+<WarpVehicle>d__5")]
		public sealed class _WarpVehicle_d__5 : Il2CppSystem.Object
		{
			// Token: 0x0600E59F RID: 58783 RVA: 0x00363270 File Offset: 0x00361470
			// Note: this type is marked as 'beforefieldinit'.
			static _WarpVehicle_d__5()
			{
				Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, "<WarpVehicle>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr);
				OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, "<>1__state");
				OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, "<>2__current");
				OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr_veh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, "veh");
				OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, "<>4__this");
				OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr__faded_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, "<faded>5__2");
				OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, 100686305);
				OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, 100686306);
				OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, 100686307);
				OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, 100686308);
				OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, 100686309);
				OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, 100686310);
			}

			// Token: 0x0600E5A0 RID: 58784 RVA: 0x00363378 File Offset: 0x00361578
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WarpVehicle_d__5(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E5A1 RID: 58785 RVA: 0x003633C0 File Offset: 0x003615C0
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E5A2 RID: 58786 RVA: 0x003633F4 File Offset: 0x003615F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316768, XrefRangeEnd = 316810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170046DA RID: 18138
			// (get) Token: 0x0600E5A3 RID: 58787 RVA: 0x00363430 File Offset: 0x00361630
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E5A4 RID: 58788 RVA: 0x00363470 File Offset: 0x00361670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316810, XrefRangeEnd = 316815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170046DB RID: 18139
			// (get) Token: 0x0600E5A5 RID: 58789 RVA: 0x003634A4 File Offset: 0x003616A4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E5A6 RID: 58790 RVA: 0x0006FA5E File Offset: 0x0006DC5E
			public _WarpVehicle_d__5(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046D5 RID: 18133
			// (get) Token: 0x0600E5A7 RID: 58791 RVA: 0x003634E4 File Offset: 0x003616E4
			// (set) Token: 0x0600E5A8 RID: 58792 RVA: 0x0006FA67 File Offset: 0x0006DC67
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170046D6 RID: 18134
			// (get) Token: 0x0600E5A9 RID: 58793 RVA: 0x0036350C File Offset: 0x0036170C
			// (set) Token: 0x0600E5AA RID: 58794 RVA: 0x0006FA82 File Offset: 0x0006DC82
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046D7 RID: 18135
			// (get) Token: 0x0600E5AB RID: 58795 RVA: 0x0036353C File Offset: 0x0036173C
			// (set) Token: 0x0600E5AC RID: 58796 RVA: 0x0006FAA1 File Offset: 0x0006DCA1
			public unsafe LandVehicle veh
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr_veh);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr_veh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046D8 RID: 18136
			// (get) Token: 0x0600E5AD RID: 58797 RVA: 0x0036356C File Offset: 0x0036176C
			// (set) Token: 0x0600E5AE RID: 58798 RVA: 0x0006FAC0 File Offset: 0x0006DCC0
			public unsafe OceanCollider __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OceanCollider>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046D9 RID: 18137
			// (get) Token: 0x0600E5AF RID: 58799 RVA: 0x0036359C File Offset: 0x0036179C
			// (set) Token: 0x0600E5B0 RID: 58800 RVA: 0x0006FADF File Offset: 0x0006DCDF
			public unsafe bool _faded_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr__faded_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr__faded_5__2)) = value;
				}
			}

			// Token: 0x040099CD RID: 39373
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040099CE RID: 39374
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040099CF RID: 39375
			private static readonly System.IntPtr NativeFieldInfoPtr_veh;

			// Token: 0x040099D0 RID: 39376
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040099D1 RID: 39377
			private static readonly System.IntPtr NativeFieldInfoPtr__faded_5__2;

			// Token: 0x040099D2 RID: 39378
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040099D3 RID: 39379
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040099D4 RID: 39380
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040099D5 RID: 39381
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040099D6 RID: 39382
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040099D7 RID: 39383
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
