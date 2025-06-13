using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x0200044B RID: 1099
	public class SlidingDoor : MonoBehaviour
	{
		// Token: 0x06005F98 RID: 24472 RVA: 0x001BA5D8 File Offset: 0x001B87D8
		// Note: this type is marked as 'beforefieldinit'.
		static SlidingDoor()
		{
			Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "SlidingDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr);
			SlidingDoor.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "<IsOpen>k__BackingField");
			SlidingDoor.NativeFieldInfoPtr_DoorTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "DoorTransform");
			SlidingDoor.NativeFieldInfoPtr_ClosedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "ClosedPosition");
			SlidingDoor.NativeFieldInfoPtr_OpenPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "OpenPosition");
			SlidingDoor.NativeFieldInfoPtr_SlideDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "SlideDuration");
			SlidingDoor.NativeFieldInfoPtr_SlideCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "SlideCurve");
			SlidingDoor.NativeFieldInfoPtr_MoveRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "MoveRoutine");
			SlidingDoor.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100675549);
			SlidingDoor.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100675550);
			SlidingDoor.NativeMethodInfoPtr_Opened_Public_Virtual_New_Void_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100675551);
			SlidingDoor.NativeMethodInfoPtr_Closed_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100675552);
			SlidingDoor.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100675553);
			SlidingDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100675554);
			SlidingDoor.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100675555);
		}

		// Token: 0x17001C9D RID: 7325
		// (get) Token: 0x06005F99 RID: 24473 RVA: 0x001BA720 File Offset: 0x001B8920
		// (set) Token: 0x06005F9A RID: 24474 RVA: 0x001BA75C File Offset: 0x001B895C
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005F9B RID: 24475 RVA: 0x001BA79C File Offset: 0x001B899C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200489, XrefRangeEnd = 200490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Opened(EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref openSide;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlidingDoor.NativeMethodInfoPtr_Opened_Public_Virtual_New_Void_EDoorSide_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F9C RID: 24476 RVA: 0x001BA7E8 File Offset: 0x001B89E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200490, XrefRangeEnd = 200491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Closed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlidingDoor.NativeMethodInfoPtr_Closed_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F9D RID: 24477 RVA: 0x001BA824 File Offset: 0x001B8A24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200499, RefRangeEnd = 200501, XrefRangeStart = 200491, XrefRangeEnd = 200499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F9E RID: 24478 RVA: 0x001BA858 File Offset: 0x001B8A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200501, XrefRangeEnd = 200502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlidingDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F9F RID: 24479 RVA: 0x001BA894 File Offset: 0x001B8A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200502, XrefRangeEnd = 200507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06005FA0 RID: 24480 RVA: 0x0002CDC1 File Offset: 0x0002AFC1
		public SlidingDoor(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C96 RID: 7318
		// (get) Token: 0x06005FA1 RID: 24481 RVA: 0x001BA8D4 File Offset: 0x001B8AD4
		// (set) Token: 0x06005FA2 RID: 24482 RVA: 0x0002CDCA File Offset: 0x0002AFCA
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C97 RID: 7319
		// (get) Token: 0x06005FA3 RID: 24483 RVA: 0x001BA8FC File Offset: 0x001B8AFC
		// (set) Token: 0x06005FA4 RID: 24484 RVA: 0x0002CDE5 File Offset: 0x0002AFE5
		public unsafe Transform DoorTransform
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_DoorTransform);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_DoorTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C98 RID: 7320
		// (get) Token: 0x06005FA5 RID: 24485 RVA: 0x001BA92C File Offset: 0x001B8B2C
		// (set) Token: 0x06005FA6 RID: 24486 RVA: 0x0002CE04 File Offset: 0x0002B004
		public unsafe Transform ClosedPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_ClosedPosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_ClosedPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C99 RID: 7321
		// (get) Token: 0x06005FA7 RID: 24487 RVA: 0x001BA95C File Offset: 0x001B8B5C
		// (set) Token: 0x06005FA8 RID: 24488 RVA: 0x0002CE23 File Offset: 0x0002B023
		public unsafe Transform OpenPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_OpenPosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_OpenPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C9A RID: 7322
		// (get) Token: 0x06005FA9 RID: 24489 RVA: 0x001BA98C File Offset: 0x001B8B8C
		// (set) Token: 0x06005FAA RID: 24490 RVA: 0x0002CE42 File Offset: 0x0002B042
		public unsafe float SlideDuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_SlideDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_SlideDuration)) = value;
			}
		}

		// Token: 0x17001C9B RID: 7323
		// (get) Token: 0x06005FAB RID: 24491 RVA: 0x001BA9B4 File Offset: 0x001B8BB4
		// (set) Token: 0x06005FAC RID: 24492 RVA: 0x0002CE5D File Offset: 0x0002B05D
		public unsafe AnimationCurve SlideCurve
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_SlideCurve);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_SlideCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C9C RID: 7324
		// (get) Token: 0x06005FAD RID: 24493 RVA: 0x001BA9E4 File Offset: 0x001B8BE4
		// (set) Token: 0x06005FAE RID: 24494 RVA: 0x0002CE7C File Offset: 0x0002B07C
		public unsafe Coroutine MoveRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_MoveRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_MoveRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004168 RID: 16744
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04004169 RID: 16745
		private static readonly System.IntPtr NativeFieldInfoPtr_DoorTransform;

		// Token: 0x0400416A RID: 16746
		private static readonly System.IntPtr NativeFieldInfoPtr_ClosedPosition;

		// Token: 0x0400416B RID: 16747
		private static readonly System.IntPtr NativeFieldInfoPtr_OpenPosition;

		// Token: 0x0400416C RID: 16748
		private static readonly System.IntPtr NativeFieldInfoPtr_SlideDuration;

		// Token: 0x0400416D RID: 16749
		private static readonly System.IntPtr NativeFieldInfoPtr_SlideCurve;

		// Token: 0x0400416E RID: 16750
		private static readonly System.IntPtr NativeFieldInfoPtr_MoveRoutine;

		// Token: 0x0400416F RID: 16751
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04004170 RID: 16752
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04004171 RID: 16753
		private static readonly System.IntPtr NativeMethodInfoPtr_Opened_Public_Virtual_New_Void_EDoorSide_0;

		// Token: 0x04004172 RID: 16754
		private static readonly System.IntPtr NativeMethodInfoPtr_Closed_Public_Virtual_New_Void_0;

		// Token: 0x04004173 RID: 16755
		private static readonly System.IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x04004174 RID: 16756
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004175 RID: 16757
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000A3D RID: 2621
		[ObfuscatedName("ScheduleOne.Doors.SlidingDoor+<<Move>g__Move|12_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D2D7 RID: 53975 RVA: 0x0032E33C File Offset: 0x0032C53C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique()
			{
				Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "<<Move>g__Move|12_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr);
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, "<>1__state");
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, "<>2__current");
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, "<>4__this");
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__start_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, "<start>5__2");
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__end_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, "<end>5__3");
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, "<i>5__4");
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, 100675556);
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, 100675557);
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, 100675558);
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, 100675559);
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, 100675560);
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, 100675561);
			}

			// Token: 0x0600D2D8 RID: 53976 RVA: 0x0032E458 File Offset: 0x0032C658
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D2D9 RID: 53977 RVA: 0x0032E4A0 File Offset: 0x0032C6A0
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D2DA RID: 53978 RVA: 0x0032E4D4 File Offset: 0x0032C6D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200468, XrefRangeEnd = 200484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004154 RID: 16724
			// (get) Token: 0x0600D2DB RID: 53979 RVA: 0x0032E510 File Offset: 0x0032C710
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D2DC RID: 53980 RVA: 0x0032E550 File Offset: 0x0032C750
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200484, XrefRangeEnd = 200489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004155 RID: 16725
			// (get) Token: 0x0600D2DD RID: 53981 RVA: 0x0032E584 File Offset: 0x0032C784
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D2DE RID: 53982 RVA: 0x0006634F File Offset: 0x0006454F
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700414E RID: 16718
			// (get) Token: 0x0600D2DF RID: 53983 RVA: 0x0032E5C4 File Offset: 0x0032C7C4
			// (set) Token: 0x0600D2E0 RID: 53984 RVA: 0x00066358 File Offset: 0x00064558
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700414F RID: 16719
			// (get) Token: 0x0600D2E1 RID: 53985 RVA: 0x0032E5EC File Offset: 0x0032C7EC
			// (set) Token: 0x0600D2E2 RID: 53986 RVA: 0x00066373 File Offset: 0x00064573
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004150 RID: 16720
			// (get) Token: 0x0600D2E3 RID: 53987 RVA: 0x0032E61C File Offset: 0x0032C81C
			// (set) Token: 0x0600D2E4 RID: 53988 RVA: 0x00066392 File Offset: 0x00064592
			public unsafe SlidingDoor __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlidingDoor>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004151 RID: 16721
			// (get) Token: 0x0600D2E5 RID: 53989 RVA: 0x0032E64C File Offset: 0x0032C84C
			// (set) Token: 0x0600D2E6 RID: 53990 RVA: 0x000663B1 File Offset: 0x000645B1
			public unsafe Vector3 _start_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__start_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__start_5__2)) = value;
				}
			}

			// Token: 0x17004152 RID: 16722
			// (get) Token: 0x0600D2E7 RID: 53991 RVA: 0x0032E674 File Offset: 0x0032C874
			// (set) Token: 0x0600D2E8 RID: 53992 RVA: 0x000663CC File Offset: 0x000645CC
			public unsafe Vector3 _end_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__end_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__end_5__3)) = value;
				}
			}

			// Token: 0x17004153 RID: 16723
			// (get) Token: 0x0600D2E9 RID: 53993 RVA: 0x0032E69C File Offset: 0x0032C89C
			// (set) Token: 0x0600D2EA RID: 53994 RVA: 0x000663E7 File Offset: 0x000645E7
			public unsafe float _i_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x04008E7A RID: 36474
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008E7B RID: 36475
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008E7C RID: 36476
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E7D RID: 36477
			private static readonly System.IntPtr NativeFieldInfoPtr__start_5__2;

			// Token: 0x04008E7E RID: 36478
			private static readonly System.IntPtr NativeFieldInfoPtr__end_5__3;

			// Token: 0x04008E7F RID: 36479
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x04008E80 RID: 36480
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008E81 RID: 36481
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E82 RID: 36482
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008E83 RID: 36483
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008E84 RID: 36484
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E85 RID: 36485
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
