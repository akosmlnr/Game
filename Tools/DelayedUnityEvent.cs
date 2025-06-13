using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000556 RID: 1366
	public class DelayedUnityEvent : MonoBehaviour
	{
		// Token: 0x060078B5 RID: 30901 RVA: 0x0020E8C8 File Offset: 0x0020CAC8
		// Note: this type is marked as 'beforefieldinit'.
		static DelayedUnityEvent()
		{
			Il2CppClassPointerStore<DelayedUnityEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "DelayedUnityEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelayedUnityEvent>.NativeClassPtr);
			DelayedUnityEvent.NativeFieldInfoPtr_Delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedUnityEvent>.NativeClassPtr, "Delay");
			DelayedUnityEvent.NativeFieldInfoPtr_onDelayStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedUnityEvent>.NativeClassPtr, "onDelayStart");
			DelayedUnityEvent.NativeFieldInfoPtr_onDelayedExecute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedUnityEvent>.NativeClassPtr, "onDelayedExecute");
			DelayedUnityEvent.NativeMethodInfoPtr_Execute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedUnityEvent>.NativeClassPtr, 100678588);
			DelayedUnityEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedUnityEvent>.NativeClassPtr, 100678589);
			DelayedUnityEvent.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedUnityEvent>.NativeClassPtr, 100678590);
		}

		// Token: 0x060078B6 RID: 30902 RVA: 0x0020E970 File Offset: 0x0020CB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234773, XrefRangeEnd = 234779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedUnityEvent.NativeMethodInfoPtr_Execute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078B7 RID: 30903 RVA: 0x0020E9A4 File Offset: 0x0020CBA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 77482, RefRangeEnd = 77486, XrefRangeStart = 77482, XrefRangeEnd = 77486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelayedUnityEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelayedUnityEvent>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedUnityEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078B8 RID: 30904 RVA: 0x0020E9E0 File Offset: 0x0020CBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234779, XrefRangeEnd = 234784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedUnityEvent.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060078B9 RID: 30905 RVA: 0x00038F6A File Offset: 0x0003716A
		public DelayedUnityEvent(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002459 RID: 9305
		// (get) Token: 0x060078BA RID: 30906 RVA: 0x0020EA20 File Offset: 0x0020CC20
		// (set) Token: 0x060078BB RID: 30907 RVA: 0x00038F73 File Offset: 0x00037173
		public unsafe float Delay
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.NativeFieldInfoPtr_Delay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.NativeFieldInfoPtr_Delay)) = value;
			}
		}

		// Token: 0x1700245A RID: 9306
		// (get) Token: 0x060078BC RID: 30908 RVA: 0x0020EA48 File Offset: 0x0020CC48
		// (set) Token: 0x060078BD RID: 30909 RVA: 0x00038F8E File Offset: 0x0003718E
		public unsafe UnityEvent onDelayStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.NativeFieldInfoPtr_onDelayStart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.NativeFieldInfoPtr_onDelayStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700245B RID: 9307
		// (get) Token: 0x060078BE RID: 30910 RVA: 0x0020EA78 File Offset: 0x0020CC78
		// (set) Token: 0x060078BF RID: 30911 RVA: 0x00038FAD File Offset: 0x000371AD
		public unsafe UnityEvent onDelayedExecute
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.NativeFieldInfoPtr_onDelayedExecute);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.NativeFieldInfoPtr_onDelayedExecute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005272 RID: 21106
		private static readonly System.IntPtr NativeFieldInfoPtr_Delay;

		// Token: 0x04005273 RID: 21107
		private static readonly System.IntPtr NativeFieldInfoPtr_onDelayStart;

		// Token: 0x04005274 RID: 21108
		private static readonly System.IntPtr NativeFieldInfoPtr_onDelayedExecute;

		// Token: 0x04005275 RID: 21109
		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_0;

		// Token: 0x04005276 RID: 21110
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005277 RID: 21111
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000AE9 RID: 2793
		[ObfuscatedName("ScheduleOne.Tools.DelayedUnityEvent+<<Execute>g__Wait|3_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D806 RID: 55302 RVA: 0x0033C770 File Offset: 0x0033A970
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique()
			{
				Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DelayedUnityEvent>.NativeClassPtr, "<<Execute>g__Wait|3_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr);
				DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, "<>1__state");
				DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, "<>2__current");
				DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, "<>4__this");
				DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100678591);
				DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100678592);
				DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100678593);
				DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100678594);
				DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100678595);
				DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100678596);
			}

			// Token: 0x0600D807 RID: 55303 RVA: 0x0033C850 File Offset: 0x0033AA50
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D808 RID: 55304 RVA: 0x0033C898 File Offset: 0x0033AA98
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D809 RID: 55305 RVA: 0x0033C8CC File Offset: 0x0033AACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234762, XrefRangeEnd = 234768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170042B5 RID: 17077
			// (get) Token: 0x0600D80A RID: 55306 RVA: 0x0033C908 File Offset: 0x0033AB08
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D80B RID: 55307 RVA: 0x0033C948 File Offset: 0x0033AB48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234768, XrefRangeEnd = 234773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170042B6 RID: 17078
			// (get) Token: 0x0600D80C RID: 55308 RVA: 0x0033C97C File Offset: 0x0033AB7C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D80D RID: 55309 RVA: 0x00068D58 File Offset: 0x00066F58
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042B2 RID: 17074
			// (get) Token: 0x0600D80E RID: 55310 RVA: 0x0033C9BC File Offset: 0x0033ABBC
			// (set) Token: 0x0600D80F RID: 55311 RVA: 0x00068D61 File Offset: 0x00066F61
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042B3 RID: 17075
			// (get) Token: 0x0600D810 RID: 55312 RVA: 0x0033C9E4 File Offset: 0x0033ABE4
			// (set) Token: 0x0600D811 RID: 55313 RVA: 0x00068D7C File Offset: 0x00066F7C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042B4 RID: 17076
			// (get) Token: 0x0600D812 RID: 55314 RVA: 0x0033CA14 File Offset: 0x0033AC14
			// (set) Token: 0x0600D813 RID: 55315 RVA: 0x00068D9B File Offset: 0x00066F9B
			public unsafe DelayedUnityEvent __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelayedUnityEvent>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091A7 RID: 37287
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040091A8 RID: 37288
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040091A9 RID: 37289
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091AA RID: 37290
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040091AB RID: 37291
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040091AC RID: 37292
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040091AD RID: 37293
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040091AE RID: 37294
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040091AF RID: 37295
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
