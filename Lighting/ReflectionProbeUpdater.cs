using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003D9 RID: 985
	public class ReflectionProbeUpdater : MonoBehaviour
	{
		// Token: 0x06004BB6 RID: 19382 RVA: 0x00170C04 File Offset: 0x0016EE04
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionProbeUpdater()
		{
			Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "ReflectionProbeUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr);
			ReflectionProbeUpdater.NativeFieldInfoPtr_Probe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, "Probe");
			ReflectionProbeUpdater.NativeFieldInfoPtr_renderQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, "renderQueue");
			ReflectionProbeUpdater.NativeFieldInfoPtr_RenderRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, "RenderRoutine");
			ReflectionProbeUpdater.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, 100672756);
			ReflectionProbeUpdater.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, 100672757);
			ReflectionProbeUpdater.NativeMethodInfoPtr_UpdateProbe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, 100672758);
			ReflectionProbeUpdater.NativeMethodInfoPtr_ProcessQueue_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, 100672759);
			ReflectionProbeUpdater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, 100672760);
		}

		// Token: 0x06004BB7 RID: 19383 RVA: 0x00170CD4 File Offset: 0x0016EED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168400, XrefRangeEnd = 168408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004BB8 RID: 19384 RVA: 0x00170D08 File Offset: 0x0016EF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168408, XrefRangeEnd = 168452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004BB9 RID: 19385 RVA: 0x00170D3C File Offset: 0x0016EF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168452, XrefRangeEnd = 168465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateProbe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater.NativeMethodInfoPtr_UpdateProbe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004BBA RID: 19386 RVA: 0x00170D70 File Offset: 0x0016EF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168465, XrefRangeEnd = 168469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ProcessQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater.NativeMethodInfoPtr_ProcessQueue_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06004BBB RID: 19387 RVA: 0x00170DB0 File Offset: 0x0016EFB0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionProbeUpdater() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004BBC RID: 19388 RVA: 0x00024577 File Offset: 0x00022777
		public ReflectionProbeUpdater(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x06004BBD RID: 19389 RVA: 0x00170DEC File Offset: 0x0016EFEC
		// (set) Token: 0x06004BBE RID: 19390 RVA: 0x00024580 File Offset: 0x00022780
		public unsafe ReflectionProbe Probe
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater.NativeFieldInfoPtr_Probe);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionProbe>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater.NativeFieldInfoPtr_Probe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x06004BBF RID: 19391 RVA: 0x00170E1C File Offset: 0x0016F01C
		// (set) Token: 0x06004BC0 RID: 19392 RVA: 0x0002459F File Offset: 0x0002279F
		public unsafe static List<ReflectionProbe> renderQueue
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionProbeUpdater.NativeFieldInfoPtr_renderQueue, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ReflectionProbe>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionProbeUpdater.NativeFieldInfoPtr_renderQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x06004BC1 RID: 19393 RVA: 0x00170E44 File Offset: 0x0016F044
		// (set) Token: 0x06004BC2 RID: 19394 RVA: 0x000245B1 File Offset: 0x000227B1
		public unsafe static Coroutine RenderRoutine
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionProbeUpdater.NativeFieldInfoPtr_RenderRoutine, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionProbeUpdater.NativeFieldInfoPtr_RenderRoutine, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040032FC RID: 13052
		private static readonly System.IntPtr NativeFieldInfoPtr_Probe;

		// Token: 0x040032FD RID: 13053
		private static readonly System.IntPtr NativeFieldInfoPtr_renderQueue;

		// Token: 0x040032FE RID: 13054
		private static readonly System.IntPtr NativeFieldInfoPtr_RenderRoutine;

		// Token: 0x040032FF RID: 13055
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04003300 RID: 13056
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003301 RID: 13057
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateProbe_Private_Void_0;

		// Token: 0x04003302 RID: 13058
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessQueue_Private_IEnumerator_0;

		// Token: 0x04003303 RID: 13059
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009D2 RID: 2514
		[ObfuscatedName("ScheduleOne.Lighting.ReflectionProbeUpdater+<ProcessQueue>d__6")]
		public sealed class _ProcessQueue_d__6 : Il2CppSystem.Object
		{
			// Token: 0x0600CF51 RID: 53073 RVA: 0x00324310 File Offset: 0x00322510
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessQueue_d__6()
			{
				Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, "<ProcessQueue>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, "<>1__state");
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, "<>2__current");
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__renderDuration_Frames_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, "<renderDuration_Frames>5__2");
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, "<i>5__3");
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100672762);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100672763);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100672764);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100672765);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100672766);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100672767);
			}

			// Token: 0x0600CF52 RID: 53074 RVA: 0x00324404 File Offset: 0x00322604
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ProcessQueue_d__6(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF53 RID: 53075 RVA: 0x0032444C File Offset: 0x0032264C
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF54 RID: 53076 RVA: 0x00324480 File Offset: 0x00322680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168373, XrefRangeEnd = 168395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x1700404D RID: 16461
			// (get) Token: 0x0600CF55 RID: 53077 RVA: 0x003244BC File Offset: 0x003226BC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CF56 RID: 53078 RVA: 0x003244FC File Offset: 0x003226FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168395, XrefRangeEnd = 168400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x1700404E RID: 16462
			// (get) Token: 0x0600CF57 RID: 53079 RVA: 0x00324530 File Offset: 0x00322730
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CF58 RID: 53080 RVA: 0x000647C2 File Offset: 0x000629C2
			public _ProcessQueue_d__6(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004049 RID: 16457
			// (get) Token: 0x0600CF59 RID: 53081 RVA: 0x00324570 File Offset: 0x00322770
			// (set) Token: 0x0600CF5A RID: 53082 RVA: 0x000647CB File Offset: 0x000629CB
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700404A RID: 16458
			// (get) Token: 0x0600CF5B RID: 53083 RVA: 0x00324598 File Offset: 0x00322798
			// (set) Token: 0x0600CF5C RID: 53084 RVA: 0x000647E6 File Offset: 0x000629E6
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700404B RID: 16459
			// (get) Token: 0x0600CF5D RID: 53085 RVA: 0x003245C8 File Offset: 0x003227C8
			// (set) Token: 0x0600CF5E RID: 53086 RVA: 0x00064805 File Offset: 0x00062A05
			public unsafe int _renderDuration_Frames_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__renderDuration_Frames_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__renderDuration_Frames_5__2)) = value;
				}
			}

			// Token: 0x1700404C RID: 16460
			// (get) Token: 0x0600CF5F RID: 53087 RVA: 0x003245F0 File Offset: 0x003227F0
			// (set) Token: 0x0600CF60 RID: 53088 RVA: 0x00064820 File Offset: 0x00062A20
			public unsafe int _i_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04008C47 RID: 35911
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008C48 RID: 35912
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008C49 RID: 35913
			private static readonly System.IntPtr NativeFieldInfoPtr__renderDuration_Frames_5__2;

			// Token: 0x04008C4A RID: 35914
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04008C4B RID: 35915
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008C4C RID: 35916
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C4D RID: 35917
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008C4E RID: 35918
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008C4F RID: 35919
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C50 RID: 35920
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
