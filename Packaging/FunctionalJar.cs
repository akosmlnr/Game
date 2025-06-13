using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000586 RID: 1414
	public class FunctionalJar : FunctionalPackaging
	{
		// Token: 0x06007B0E RID: 31502 RVA: 0x002155B0 File Offset: 0x002137B0
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalJar()
		{
			Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FunctionalJar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr);
			FunctionalJar.NativeFieldInfoPtr__HoveredCursor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "<HoveredCursor>k__BackingField");
			FunctionalJar.NativeFieldInfoPtr_Lid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "Lid");
			FunctionalJar.NativeFieldInfoPtr_LidStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "LidStartPoint");
			FunctionalJar.NativeFieldInfoPtr_LidSensor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "LidSensor");
			FunctionalJar.NativeFieldInfoPtr_LidCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "LidCollider");
			FunctionalJar.NativeFieldInfoPtr_FullyPackedBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "FullyPackedBlocker");
			FunctionalJar.NativeFieldInfoPtr_LidObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "LidObject");
			FunctionalJar.NativeFieldInfoPtr_lidPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "lidPosition");
			FunctionalJar.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678823);
			FunctionalJar.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678824);
			FunctionalJar.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_PackagingStation_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678825);
			FunctionalJar.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678826);
			FunctionalJar.NativeMethodInfoPtr_EnableSealing_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678827);
			FunctionalJar.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678828);
			FunctionalJar.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678829);
			FunctionalJar.NativeMethodInfoPtr_Seal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678830);
			FunctionalJar.NativeMethodInfoPtr_FullyPacked_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678831);
			FunctionalJar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678832);
		}

		// Token: 0x1700250A RID: 9482
		// (get) Token: 0x06007B0F RID: 31503 RVA: 0x00215748 File Offset: 0x00213948
		// (set) Token: 0x06007B10 RID: 31504 RVA: 0x00215790 File Offset: 0x00213990
		public unsafe override CursorManager.ECursorType HoveredCursor
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 63475, RefRangeEnd = 63515, XrefRangeStart = 63475, XrefRangeEnd = 63515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007B11 RID: 31505 RVA: 0x002157DC File Offset: 0x002139DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236500, XrefRangeEnd = 236528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(PackagingStation _station, Transform alignment, bool align = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_station);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref align;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_PackagingStation_Transform_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B12 RID: 31506 RVA: 0x0021584C File Offset: 0x00213A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236528, XrefRangeEnd = 236537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B13 RID: 31507 RVA: 0x00215888 File Offset: 0x00213A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236537, XrefRangeEnd = 236541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EnableSealing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_EnableSealing_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B14 RID: 31508 RVA: 0x002158C4 File Offset: 0x00213AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236541, XrefRangeEnd = 236542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B15 RID: 31509 RVA: 0x00215900 File Offset: 0x00213B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236542, XrefRangeEnd = 236553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B16 RID: 31510 RVA: 0x00215950 File Offset: 0x00213B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236553, XrefRangeEnd = 236570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Seal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_Seal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B17 RID: 31511 RVA: 0x0021598C File Offset: 0x00213B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236570, XrefRangeEnd = 236573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FullyPacked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_FullyPacked_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B18 RID: 31512 RVA: 0x002159C8 File Offset: 0x00213BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236573, XrefRangeEnd = 236576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalJar() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalJar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B19 RID: 31513 RVA: 0x0003A2AC File Offset: 0x000384AC
		public FunctionalJar(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002502 RID: 9474
		// (get) Token: 0x06007B1A RID: 31514 RVA: 0x00215A04 File Offset: 0x00213C04
		// (set) Token: 0x06007B1B RID: 31515 RVA: 0x0003A2B5 File Offset: 0x000384B5
		public new unsafe CursorManager.ECursorType _HoveredCursor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr__HoveredCursor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr__HoveredCursor_k__BackingField)) = value;
			}
		}

		// Token: 0x17002503 RID: 9475
		// (get) Token: 0x06007B1C RID: 31516 RVA: 0x00215A2C File Offset: 0x00213C2C
		// (set) Token: 0x06007B1D RID: 31517 RVA: 0x0003A2D0 File Offset: 0x000384D0
		public unsafe Draggable Lid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_Lid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_Lid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002504 RID: 9476
		// (get) Token: 0x06007B1E RID: 31518 RVA: 0x00215A5C File Offset: 0x00213C5C
		// (set) Token: 0x06007B1F RID: 31519 RVA: 0x0003A2EF File Offset: 0x000384EF
		public unsafe Transform LidStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002505 RID: 9477
		// (get) Token: 0x06007B20 RID: 31520 RVA: 0x00215A8C File Offset: 0x00213C8C
		// (set) Token: 0x06007B21 RID: 31521 RVA: 0x0003A30E File Offset: 0x0003850E
		public unsafe Collider LidSensor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidSensor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidSensor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002506 RID: 9478
		// (get) Token: 0x06007B22 RID: 31522 RVA: 0x00215ABC File Offset: 0x00213CBC
		// (set) Token: 0x06007B23 RID: 31523 RVA: 0x0003A32D File Offset: 0x0003852D
		public unsafe Collider LidCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002507 RID: 9479
		// (get) Token: 0x06007B24 RID: 31524 RVA: 0x00215AEC File Offset: 0x00213CEC
		// (set) Token: 0x06007B25 RID: 31525 RVA: 0x0003A34C File Offset: 0x0003854C
		public unsafe GameObject FullyPackedBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_FullyPackedBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_FullyPackedBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002508 RID: 9480
		// (get) Token: 0x06007B26 RID: 31526 RVA: 0x00215B1C File Offset: 0x00213D1C
		// (set) Token: 0x06007B27 RID: 31527 RVA: 0x0003A36B File Offset: 0x0003856B
		public unsafe GameObject LidObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002509 RID: 9481
		// (get) Token: 0x06007B28 RID: 31528 RVA: 0x00215B4C File Offset: 0x00213D4C
		// (set) Token: 0x06007B29 RID: 31529 RVA: 0x0003A38A File Offset: 0x0003858A
		public unsafe Vector3 lidPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_lidPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_lidPosition)) = value;
			}
		}

		// Token: 0x040053CE RID: 21454
		private static readonly IntPtr NativeFieldInfoPtr__HoveredCursor_k__BackingField;

		// Token: 0x040053CF RID: 21455
		private static readonly IntPtr NativeFieldInfoPtr_Lid;

		// Token: 0x040053D0 RID: 21456
		private static readonly IntPtr NativeFieldInfoPtr_LidStartPoint;

		// Token: 0x040053D1 RID: 21457
		private static readonly IntPtr NativeFieldInfoPtr_LidSensor;

		// Token: 0x040053D2 RID: 21458
		private static readonly IntPtr NativeFieldInfoPtr_LidCollider;

		// Token: 0x040053D3 RID: 21459
		private static readonly IntPtr NativeFieldInfoPtr_FullyPackedBlocker;

		// Token: 0x040053D4 RID: 21460
		private static readonly IntPtr NativeFieldInfoPtr_LidObject;

		// Token: 0x040053D5 RID: 21461
		private static readonly IntPtr NativeFieldInfoPtr_lidPosition;

		// Token: 0x040053D6 RID: 21462
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0;

		// Token: 0x040053D7 RID: 21463
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0;

		// Token: 0x040053D8 RID: 21464
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_PackagingStation_Transform_Boolean_0;

		// Token: 0x040053D9 RID: 21465
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

		// Token: 0x040053DA RID: 21466
		private static readonly IntPtr NativeMethodInfoPtr_EnableSealing_Protected_Virtual_Void_0;

		// Token: 0x040053DB RID: 21467
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x040053DC RID: 21468
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_Void_Collider_0;

		// Token: 0x040053DD RID: 21469
		private static readonly IntPtr NativeMethodInfoPtr_Seal_Public_Virtual_Void_0;

		// Token: 0x040053DE RID: 21470
		private static readonly IntPtr NativeMethodInfoPtr_FullyPacked_Protected_Virtual_Void_0;

		// Token: 0x040053DF RID: 21471
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
