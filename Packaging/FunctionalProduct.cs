using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x0200058D RID: 1421
	public class FunctionalProduct : Draggable
	{
		// Token: 0x06007BF7 RID: 31735 RVA: 0x00217DB0 File Offset: 0x00215FB0
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalProduct()
		{
			Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FunctionalProduct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr);
			FunctionalProduct.NativeFieldInfoPtr_ClampZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "ClampZ");
			FunctionalProduct.NativeFieldInfoPtr_AlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "AlignmentPoint");
			FunctionalProduct.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "Visuals");
			FunctionalProduct.NativeFieldInfoPtr_startLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "startLocalPos");
			FunctionalProduct.NativeFieldInfoPtr_lowestMaxZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "lowestMaxZ");
			FunctionalProduct.NativeFieldInfoPtr__VelocityCalculator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "<VelocityCalculator>k__BackingField");
			FunctionalProduct.NativeMethodInfoPtr_get_VelocityCalculator_Public_get_SmoothedVelocityCalculator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678898);
			FunctionalProduct.NativeMethodInfoPtr_set_VelocityCalculator_Private_set_Void_SmoothedVelocityCalculator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678899);
			FunctionalProduct.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_ItemInstance_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678900);
			FunctionalProduct.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678901);
			FunctionalProduct.NativeMethodInfoPtr_InitializeVisuals_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678902);
			FunctionalProduct.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678903);
			FunctionalProduct.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678904);
			FunctionalProduct.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678905);
			FunctionalProduct.NativeMethodInfoPtr_Clamp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678906);
			FunctionalProduct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100678907);
		}

		// Token: 0x1700255E RID: 9566
		// (get) Token: 0x06007BF8 RID: 31736 RVA: 0x00217F20 File Offset: 0x00216120
		// (set) Token: 0x06007BF9 RID: 31737 RVA: 0x00217F60 File Offset: 0x00216160
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalProduct.NativeMethodInfoPtr_get_VelocityCalculator_Public_get_SmoothedVelocityCalculator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalProduct.NativeMethodInfoPtr_set_VelocityCalculator_Private_set_Void_SmoothedVelocityCalculator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007BFA RID: 31738 RVA: 0x00217FA4 File Offset: 0x002161A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237246, XrefRangeEnd = 237264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(PackagingStation station, ItemInstance item, Transform alignment, bool align = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref align;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_ItemInstance_Transform_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BFB RID: 31739 RVA: 0x00218024 File Offset: 0x00216224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237264, XrefRangeEnd = 237281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BFC RID: 31740 RVA: 0x00218074 File Offset: 0x00216274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237281, XrefRangeEnd = 237289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeVisuals(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_InitializeVisuals_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BFD RID: 31741 RVA: 0x002180C4 File Offset: 0x002162C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 237302, RefRangeEnd = 237304, XrefRangeStart = 237289, XrefRangeEnd = 237302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignTo(Transform alignment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalProduct.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BFE RID: 31742 RVA: 0x00218108 File Offset: 0x00216308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237304, XrefRangeEnd = 237305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BFF RID: 31743 RVA: 0x00218144 File Offset: 0x00216344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237305, XrefRangeEnd = 237317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C00 RID: 31744 RVA: 0x00218180 File Offset: 0x00216380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237317, XrefRangeEnd = 237328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clamp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalProduct.NativeMethodInfoPtr_Clamp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C01 RID: 31745 RVA: 0x002181B4 File Offset: 0x002163B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 237329, RefRangeEnd = 237331, XrefRangeStart = 237328, XrefRangeEnd = 237329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalProduct() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalProduct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C02 RID: 31746 RVA: 0x0003AC9A File Offset: 0x00038E9A
		public FunctionalProduct(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002558 RID: 9560
		// (get) Token: 0x06007C03 RID: 31747 RVA: 0x002181F0 File Offset: 0x002163F0
		// (set) Token: 0x06007C04 RID: 31748 RVA: 0x0003ACA3 File Offset: 0x00038EA3
		public unsafe bool ClampZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_ClampZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_ClampZ)) = value;
			}
		}

		// Token: 0x17002559 RID: 9561
		// (get) Token: 0x06007C05 RID: 31749 RVA: 0x00218218 File Offset: 0x00216418
		// (set) Token: 0x06007C06 RID: 31750 RVA: 0x0003ACBE File Offset: 0x00038EBE
		public unsafe Transform AlignmentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_AlignmentPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_AlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700255A RID: 9562
		// (get) Token: 0x06007C07 RID: 31751 RVA: 0x00218248 File Offset: 0x00216448
		// (set) Token: 0x06007C08 RID: 31752 RVA: 0x0003ACDD File Offset: 0x00038EDD
		public unsafe FilledPackagingVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700255B RID: 9563
		// (get) Token: 0x06007C09 RID: 31753 RVA: 0x00218278 File Offset: 0x00216478
		// (set) Token: 0x06007C0A RID: 31754 RVA: 0x0003ACFC File Offset: 0x00038EFC
		public unsafe Vector3 startLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_startLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_startLocalPos)) = value;
			}
		}

		// Token: 0x1700255C RID: 9564
		// (get) Token: 0x06007C0B RID: 31755 RVA: 0x002182A0 File Offset: 0x002164A0
		// (set) Token: 0x06007C0C RID: 31756 RVA: 0x0003AD17 File Offset: 0x00038F17
		public unsafe float lowestMaxZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_lowestMaxZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_lowestMaxZ)) = value;
			}
		}

		// Token: 0x1700255D RID: 9565
		// (get) Token: 0x06007C0D RID: 31757 RVA: 0x002182C8 File Offset: 0x002164C8
		// (set) Token: 0x06007C0E RID: 31758 RVA: 0x0003AD32 File Offset: 0x00038F32
		public unsafe SmoothedVelocityCalculator _VelocityCalculator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr__VelocityCalculator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr__VelocityCalculator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005458 RID: 21592
		private static readonly IntPtr NativeFieldInfoPtr_ClampZ;

		// Token: 0x04005459 RID: 21593
		private static readonly IntPtr NativeFieldInfoPtr_AlignmentPoint;

		// Token: 0x0400545A RID: 21594
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x0400545B RID: 21595
		private static readonly IntPtr NativeFieldInfoPtr_startLocalPos;

		// Token: 0x0400545C RID: 21596
		private static readonly IntPtr NativeFieldInfoPtr_lowestMaxZ;

		// Token: 0x0400545D RID: 21597
		private static readonly IntPtr NativeFieldInfoPtr__VelocityCalculator_k__BackingField;

		// Token: 0x0400545E RID: 21598
		private static readonly IntPtr NativeMethodInfoPtr_get_VelocityCalculator_Public_get_SmoothedVelocityCalculator_0;

		// Token: 0x0400545F RID: 21599
		private static readonly IntPtr NativeMethodInfoPtr_set_VelocityCalculator_Private_set_Void_SmoothedVelocityCalculator_0;

		// Token: 0x04005460 RID: 21600
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_ItemInstance_Transform_Boolean_0;

		// Token: 0x04005461 RID: 21601
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04005462 RID: 21602
		private static readonly IntPtr NativeMethodInfoPtr_InitializeVisuals_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04005463 RID: 21603
		private static readonly IntPtr NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0;

		// Token: 0x04005464 RID: 21604
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0;

		// Token: 0x04005465 RID: 21605
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x04005466 RID: 21606
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Private_Void_0;

		// Token: 0x04005467 RID: 21607
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
