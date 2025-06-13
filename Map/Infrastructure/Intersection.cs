using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map.Infrastructure
{
	// Token: 0x020007B5 RID: 1973
	public class Intersection : MonoBehaviour
	{
		// Token: 0x0600BA9C RID: 47772 RVA: 0x002E7D38 File Offset: 0x002E5F38
		// Note: this type is marked as 'beforefieldinit'.
		static Intersection()
		{
			Il2CppClassPointerStore<Intersection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map.Infrastructure", "Intersection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Intersection>.NativeClassPtr);
			Intersection.NativeFieldInfoPtr_path1Lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path1Lights");
			Intersection.NativeFieldInfoPtr_path2Lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path2Lights");
			Intersection.NativeFieldInfoPtr_path1Obstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path1Obstacles");
			Intersection.NativeFieldInfoPtr_path2Obstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path2Obstacles");
			Intersection.NativeFieldInfoPtr_path1Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path1Time");
			Intersection.NativeFieldInfoPtr_path2Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path2Time");
			Intersection.NativeFieldInfoPtr_timeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "timeOffset");
			Intersection.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection>.NativeClassPtr, 100686386);
			Intersection.NativeMethodInfoPtr_Run_Protected_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection>.NativeClassPtr, 100686387);
			Intersection.NativeMethodInfoPtr_SetPath1Lights_Protected_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection>.NativeClassPtr, 100686388);
			Intersection.NativeMethodInfoPtr_SetPath2Lights_Protected_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection>.NativeClassPtr, 100686389);
			Intersection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection>.NativeClassPtr, 100686390);
		}

		// Token: 0x0600BA9D RID: 47773 RVA: 0x002E7E58 File Offset: 0x002E6058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317627, XrefRangeEnd = 317638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Intersection.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA9E RID: 47774 RVA: 0x002E7E94 File Offset: 0x002E6094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317638, XrefRangeEnd = 317643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection.NativeMethodInfoPtr_Run_Protected_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600BA9F RID: 47775 RVA: 0x002E7ED4 File Offset: 0x002E60D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317685, RefRangeEnd = 317686, XrefRangeStart = 317643, XrefRangeEnd = 317685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPath1Lights(TrafficLight.State state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref state;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection.NativeMethodInfoPtr_SetPath1Lights_Protected_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAA0 RID: 47776 RVA: 0x002E7F14 File Offset: 0x002E6114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317686, XrefRangeEnd = 317728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPath2Lights(TrafficLight.State state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref state;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection.NativeMethodInfoPtr_SetPath2Lights_Protected_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAA1 RID: 47777 RVA: 0x002E7F54 File Offset: 0x002E6154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317728, XrefRangeEnd = 317753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Intersection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Intersection>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAA2 RID: 47778 RVA: 0x0005B426 File Offset: 0x00059626
		public Intersection(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003993 RID: 14739
		// (get) Token: 0x0600BAA3 RID: 47779 RVA: 0x002E7F90 File Offset: 0x002E6190
		// (set) Token: 0x0600BAA4 RID: 47780 RVA: 0x0005B42F File Offset: 0x0005962F
		public unsafe List<TrafficLight> path1Lights
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Lights);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrafficLight>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003994 RID: 14740
		// (get) Token: 0x0600BAA5 RID: 47781 RVA: 0x002E7FC0 File Offset: 0x002E61C0
		// (set) Token: 0x0600BAA6 RID: 47782 RVA: 0x0005B44E File Offset: 0x0005964E
		public unsafe List<TrafficLight> path2Lights
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Lights);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrafficLight>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003995 RID: 14741
		// (get) Token: 0x0600BAA7 RID: 47783 RVA: 0x002E7FF0 File Offset: 0x002E61F0
		// (set) Token: 0x0600BAA8 RID: 47784 RVA: 0x0005B46D File Offset: 0x0005966D
		public unsafe List<GameObject> path1Obstacles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Obstacles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Obstacles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003996 RID: 14742
		// (get) Token: 0x0600BAA9 RID: 47785 RVA: 0x002E8020 File Offset: 0x002E6220
		// (set) Token: 0x0600BAAA RID: 47786 RVA: 0x0005B48C File Offset: 0x0005968C
		public unsafe List<GameObject> path2Obstacles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Obstacles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Obstacles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003997 RID: 14743
		// (get) Token: 0x0600BAAB RID: 47787 RVA: 0x002E8050 File Offset: 0x002E6250
		// (set) Token: 0x0600BAAC RID: 47788 RVA: 0x0005B4AB File Offset: 0x000596AB
		public unsafe float path1Time
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Time)) = value;
			}
		}

		// Token: 0x17003998 RID: 14744
		// (get) Token: 0x0600BAAD RID: 47789 RVA: 0x002E8078 File Offset: 0x002E6278
		// (set) Token: 0x0600BAAE RID: 47790 RVA: 0x0005B4C6 File Offset: 0x000596C6
		public unsafe float path2Time
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Time)) = value;
			}
		}

		// Token: 0x17003999 RID: 14745
		// (get) Token: 0x0600BAAF RID: 47791 RVA: 0x002E80A0 File Offset: 0x002E62A0
		// (set) Token: 0x0600BAB0 RID: 47792 RVA: 0x0005B4E1 File Offset: 0x000596E1
		public unsafe float timeOffset
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_timeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_timeOffset)) = value;
			}
		}

		// Token: 0x04007DD7 RID: 32215
		private static readonly System.IntPtr NativeFieldInfoPtr_path1Lights;

		// Token: 0x04007DD8 RID: 32216
		private static readonly System.IntPtr NativeFieldInfoPtr_path2Lights;

		// Token: 0x04007DD9 RID: 32217
		private static readonly System.IntPtr NativeFieldInfoPtr_path1Obstacles;

		// Token: 0x04007DDA RID: 32218
		private static readonly System.IntPtr NativeFieldInfoPtr_path2Obstacles;

		// Token: 0x04007DDB RID: 32219
		private static readonly System.IntPtr NativeFieldInfoPtr_path1Time;

		// Token: 0x04007DDC RID: 32220
		private static readonly System.IntPtr NativeFieldInfoPtr_path2Time;

		// Token: 0x04007DDD RID: 32221
		private static readonly System.IntPtr NativeFieldInfoPtr_timeOffset;

		// Token: 0x04007DDE RID: 32222
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04007DDF RID: 32223
		private static readonly System.IntPtr NativeMethodInfoPtr_Run_Protected_IEnumerator_0;

		// Token: 0x04007DE0 RID: 32224
		private static readonly System.IntPtr NativeMethodInfoPtr_SetPath1Lights_Protected_Void_State_0;

		// Token: 0x04007DE1 RID: 32225
		private static readonly System.IntPtr NativeMethodInfoPtr_SetPath2Lights_Protected_Void_State_0;

		// Token: 0x04007DE2 RID: 32226
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C64 RID: 3172
		[ObfuscatedName("ScheduleOne.Map.Infrastructure.Intersection+<Run>d__8")]
		public sealed class _Run_d__8 : Il2CppSystem.Object
		{
			// Token: 0x0600E5D7 RID: 58839 RVA: 0x00363C8C File Offset: 0x00361E8C
			// Note: this type is marked as 'beforefieldinit'.
			static _Run_d__8()
			{
				Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "<Run>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr);
				Intersection._Run_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, "<>1__state");
				Intersection._Run_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, "<>2__current");
				Intersection._Run_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, "<>4__this");
				Intersection._Run_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, 100686391);
				Intersection._Run_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, 100686392);
				Intersection._Run_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, 100686393);
				Intersection._Run_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, 100686394);
				Intersection._Run_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, 100686395);
				Intersection._Run_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, 100686396);
			}

			// Token: 0x0600E5D8 RID: 58840 RVA: 0x00363D6C File Offset: 0x00361F6C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Run_d__8(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E5D9 RID: 58841 RVA: 0x00363DB4 File Offset: 0x00361FB4
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E5DA RID: 58842 RVA: 0x00363DE8 File Offset: 0x00361FE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317611, XrefRangeEnd = 317622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170046EA RID: 18154
			// (get) Token: 0x0600E5DB RID: 58843 RVA: 0x00363E24 File Offset: 0x00362024
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E5DC RID: 58844 RVA: 0x00363E64 File Offset: 0x00362064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317622, XrefRangeEnd = 317627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170046EB RID: 18155
			// (get) Token: 0x0600E5DD RID: 58845 RVA: 0x00363E98 File Offset: 0x00362098
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E5DE RID: 58846 RVA: 0x0006FBE3 File Offset: 0x0006DDE3
			public _Run_d__8(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046E7 RID: 18151
			// (get) Token: 0x0600E5DF RID: 58847 RVA: 0x00363ED8 File Offset: 0x003620D8
			// (set) Token: 0x0600E5E0 RID: 58848 RVA: 0x0006FBEC File Offset: 0x0006DDEC
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170046E8 RID: 18152
			// (get) Token: 0x0600E5E1 RID: 58849 RVA: 0x00363F00 File Offset: 0x00362100
			// (set) Token: 0x0600E5E2 RID: 58850 RVA: 0x0006FC07 File Offset: 0x0006DE07
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__8.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046E9 RID: 18153
			// (get) Token: 0x0600E5E3 RID: 58851 RVA: 0x00363F30 File Offset: 0x00362130
			// (set) Token: 0x0600E5E4 RID: 58852 RVA: 0x0006FC26 File Offset: 0x0006DE26
			public unsafe Intersection __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__8.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Intersection>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099F9 RID: 39417
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040099FA RID: 39418
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040099FB RID: 39419
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040099FC RID: 39420
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040099FD RID: 39421
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040099FE RID: 39422
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040099FF RID: 39423
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009A00 RID: 39424
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009A01 RID: 39425
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
