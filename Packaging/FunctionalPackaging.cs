using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.Tools;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x0200058C RID: 1420
	public class FunctionalPackaging : Draggable
	{
		// Token: 0x06007BC1 RID: 31681 RVA: 0x00217380 File Offset: 0x00215580
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalPackaging()
		{
			Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FunctionalPackaging");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr);
			FunctionalPackaging.NativeFieldInfoPtr__IsSealed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "<IsSealed>k__BackingField");
			FunctionalPackaging.NativeFieldInfoPtr__IsFull_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "<IsFull>k__BackingField");
			FunctionalPackaging.NativeFieldInfoPtr__ReachedOutput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "<ReachedOutput>k__BackingField");
			FunctionalPackaging.NativeFieldInfoPtr_SealInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "SealInstruction");
			FunctionalPackaging.NativeFieldInfoPtr_AutoEnableSealing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "AutoEnableSealing");
			FunctionalPackaging.NativeFieldInfoPtr_ProductContactTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "ProductContactTime");
			FunctionalPackaging.NativeFieldInfoPtr_ProductContactMaxVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "ProductContactMaxVelocity");
			FunctionalPackaging.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "Definition");
			FunctionalPackaging.NativeFieldInfoPtr_AlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "AlignmentPoint");
			FunctionalPackaging.NativeFieldInfoPtr_ProductAlignmentPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "ProductAlignmentPoints");
			FunctionalPackaging.NativeFieldInfoPtr_SealSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "SealSound");
			FunctionalPackaging.NativeFieldInfoPtr_PackedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "PackedProducts");
			FunctionalPackaging.NativeFieldInfoPtr_onFullyPacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "onFullyPacked");
			FunctionalPackaging.NativeFieldInfoPtr_onSealed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "onSealed");
			FunctionalPackaging.NativeFieldInfoPtr_onReachOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "onReachOutput");
			FunctionalPackaging.NativeFieldInfoPtr_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "station");
			FunctionalPackaging.NativeFieldInfoPtr_productContactTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "productContactTime");
			FunctionalPackaging.NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, "VelocityCalculator");
			FunctionalPackaging.NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678882);
			FunctionalPackaging.NativeMethodInfoPtr_set_IsSealed_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678883);
			FunctionalPackaging.NativeMethodInfoPtr_get_IsFull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678884);
			FunctionalPackaging.NativeMethodInfoPtr_set_IsFull_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678885);
			FunctionalPackaging.NativeMethodInfoPtr_get_ReachedOutput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678886);
			FunctionalPackaging.NativeMethodInfoPtr_set_ReachedOutput_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678887);
			FunctionalPackaging.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678888);
			FunctionalPackaging.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678889);
			FunctionalPackaging.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678890);
			FunctionalPackaging.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678891);
			FunctionalPackaging.NativeMethodInfoPtr_PackProduct_Protected_Virtual_New_Void_FunctionalProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678892);
			FunctionalPackaging.NativeMethodInfoPtr_FullyPacked_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678893);
			FunctionalPackaging.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678894);
			FunctionalPackaging.NativeMethodInfoPtr_EnableSealing_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678895);
			FunctionalPackaging.NativeMethodInfoPtr_Seal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678896);
			FunctionalPackaging.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr, 100678897);
		}

		// Token: 0x17002555 RID: 9557
		// (get) Token: 0x06007BC2 RID: 31682 RVA: 0x00217658 File Offset: 0x00215858
		// (set) Token: 0x06007BC3 RID: 31683 RVA: 0x00217694 File Offset: 0x00215894
		public unsafe bool IsSealed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_set_IsSealed_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002556 RID: 9558
		// (get) Token: 0x06007BC4 RID: 31684 RVA: 0x002176D4 File Offset: 0x002158D4
		// (set) Token: 0x06007BC5 RID: 31685 RVA: 0x00217710 File Offset: 0x00215910
		public unsafe bool IsFull
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_get_IsFull_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_set_IsFull_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002557 RID: 9559
		// (get) Token: 0x06007BC6 RID: 31686 RVA: 0x00217750 File Offset: 0x00215950
		// (set) Token: 0x06007BC7 RID: 31687 RVA: 0x0021778C File Offset: 0x0021598C
		public unsafe bool ReachedOutput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_get_ReachedOutput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_set_ReachedOutput_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007BC8 RID: 31688 RVA: 0x002177CC File Offset: 0x002159CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237039, XrefRangeEnd = 237051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(PackagingStation _station, Transform alignment, bool align = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_station);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref align;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_Transform_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BC9 RID: 31689 RVA: 0x0021783C File Offset: 0x00215A3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 237081, RefRangeEnd = 237084, XrefRangeStart = 237051, XrefRangeEnd = 237081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignTo(Transform alignment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BCA RID: 31690 RVA: 0x00217880 File Offset: 0x00215A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237084, XrefRangeEnd = 237089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BCB RID: 31691 RVA: 0x002178BC File Offset: 0x00215ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237089, XrefRangeEnd = 237120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BCC RID: 31692 RVA: 0x002178F8 File Offset: 0x00215AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237120, XrefRangeEnd = 237139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PackProduct(FunctionalProduct product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_PackProduct_Protected_Virtual_New_Void_FunctionalProduct_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BCD RID: 31693 RVA: 0x00217948 File Offset: 0x00215B48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 237157, RefRangeEnd = 237159, XrefRangeStart = 237139, XrefRangeEnd = 237157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FullyPacked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_FullyPacked_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BCE RID: 31694 RVA: 0x00217984 File Offset: 0x00215B84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237199, RefRangeEnd = 237200, XrefRangeStart = 237159, XrefRangeEnd = 237199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BCF RID: 31695 RVA: 0x002179D4 File Offset: 0x00215BD4
		[CallerCount(0)]
		public unsafe virtual void EnableSealing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_EnableSealing_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BD0 RID: 31696 RVA: 0x00217A10 File Offset: 0x00215C10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 237223, RefRangeEnd = 237225, XrefRangeStart = 237200, XrefRangeEnd = 237223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Seal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalPackaging.NativeMethodInfoPtr_Seal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BD1 RID: 31697 RVA: 0x00217A4C File Offset: 0x00215C4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 237244, RefRangeEnd = 237246, XrefRangeStart = 237225, XrefRangeEnd = 237244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalPackaging() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalPackaging>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalPackaging.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BD2 RID: 31698 RVA: 0x0003AA7B File Offset: 0x00038C7B
		public FunctionalPackaging(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002543 RID: 9539
		// (get) Token: 0x06007BD3 RID: 31699 RVA: 0x00217A88 File Offset: 0x00215C88
		// (set) Token: 0x06007BD4 RID: 31700 RVA: 0x0003AA84 File Offset: 0x00038C84
		public unsafe bool _IsSealed_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__IsSealed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__IsSealed_k__BackingField)) = value;
			}
		}

		// Token: 0x17002544 RID: 9540
		// (get) Token: 0x06007BD5 RID: 31701 RVA: 0x00217AB0 File Offset: 0x00215CB0
		// (set) Token: 0x06007BD6 RID: 31702 RVA: 0x0003AA9F File Offset: 0x00038C9F
		public unsafe bool _IsFull_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__IsFull_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__IsFull_k__BackingField)) = value;
			}
		}

		// Token: 0x17002545 RID: 9541
		// (get) Token: 0x06007BD7 RID: 31703 RVA: 0x00217AD8 File Offset: 0x00215CD8
		// (set) Token: 0x06007BD8 RID: 31704 RVA: 0x0003AABA File Offset: 0x00038CBA
		public unsafe bool _ReachedOutput_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__ReachedOutput_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr__ReachedOutput_k__BackingField)) = value;
			}
		}

		// Token: 0x17002546 RID: 9542
		// (get) Token: 0x06007BD9 RID: 31705 RVA: 0x00217B00 File Offset: 0x00215D00
		// (set) Token: 0x06007BDA RID: 31706 RVA: 0x0003AAD5 File Offset: 0x00038CD5
		public unsafe string SealInstruction
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_SealInstruction);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_SealInstruction), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002547 RID: 9543
		// (get) Token: 0x06007BDB RID: 31707 RVA: 0x00217B28 File Offset: 0x00215D28
		// (set) Token: 0x06007BDC RID: 31708 RVA: 0x0003AAF4 File Offset: 0x00038CF4
		public unsafe bool AutoEnableSealing
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_AutoEnableSealing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_AutoEnableSealing)) = value;
			}
		}

		// Token: 0x17002548 RID: 9544
		// (get) Token: 0x06007BDD RID: 31709 RVA: 0x00217B50 File Offset: 0x00215D50
		// (set) Token: 0x06007BDE RID: 31710 RVA: 0x0003AB0F File Offset: 0x00038D0F
		public unsafe float ProductContactTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductContactTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductContactTime)) = value;
			}
		}

		// Token: 0x17002549 RID: 9545
		// (get) Token: 0x06007BDF RID: 31711 RVA: 0x00217B78 File Offset: 0x00215D78
		// (set) Token: 0x06007BE0 RID: 31712 RVA: 0x0003AB2A File Offset: 0x00038D2A
		public unsafe float ProductContactMaxVelocity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductContactMaxVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductContactMaxVelocity)) = value;
			}
		}

		// Token: 0x1700254A RID: 9546
		// (get) Token: 0x06007BE1 RID: 31713 RVA: 0x00217BA0 File Offset: 0x00215DA0
		// (set) Token: 0x06007BE2 RID: 31714 RVA: 0x0003AB45 File Offset: 0x00038D45
		public unsafe PackagingDefinition Definition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_Definition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingDefinition>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700254B RID: 9547
		// (get) Token: 0x06007BE3 RID: 31715 RVA: 0x00217BD0 File Offset: 0x00215DD0
		// (set) Token: 0x06007BE4 RID: 31716 RVA: 0x0003AB64 File Offset: 0x00038D64
		public unsafe Transform AlignmentPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_AlignmentPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_AlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700254C RID: 9548
		// (get) Token: 0x06007BE5 RID: 31717 RVA: 0x00217C00 File Offset: 0x00215E00
		// (set) Token: 0x06007BE6 RID: 31718 RVA: 0x0003AB83 File Offset: 0x00038D83
		public unsafe Il2CppReferenceArray<Transform> ProductAlignmentPoints
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductAlignmentPoints);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_ProductAlignmentPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700254D RID: 9549
		// (get) Token: 0x06007BE7 RID: 31719 RVA: 0x00217C30 File Offset: 0x00215E30
		// (set) Token: 0x06007BE8 RID: 31720 RVA: 0x0003ABA2 File Offset: 0x00038DA2
		public unsafe AudioSourceController SealSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_SealSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_SealSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700254E RID: 9550
		// (get) Token: 0x06007BE9 RID: 31721 RVA: 0x00217C60 File Offset: 0x00215E60
		// (set) Token: 0x06007BEA RID: 31722 RVA: 0x0003ABC1 File Offset: 0x00038DC1
		public unsafe List<FunctionalProduct> PackedProducts
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_PackedProducts);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunctionalProduct>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_PackedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700254F RID: 9551
		// (get) Token: 0x06007BEB RID: 31723 RVA: 0x00217C90 File Offset: 0x00215E90
		// (set) Token: 0x06007BEC RID: 31724 RVA: 0x0003ABE0 File Offset: 0x00038DE0
		public unsafe Il2CppSystem.Action onFullyPacked
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onFullyPacked);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onFullyPacked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002550 RID: 9552
		// (get) Token: 0x06007BED RID: 31725 RVA: 0x00217CC0 File Offset: 0x00215EC0
		// (set) Token: 0x06007BEE RID: 31726 RVA: 0x0003ABFF File Offset: 0x00038DFF
		public unsafe Il2CppSystem.Action onSealed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onSealed);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onSealed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002551 RID: 9553
		// (get) Token: 0x06007BEF RID: 31727 RVA: 0x00217CF0 File Offset: 0x00215EF0
		// (set) Token: 0x06007BF0 RID: 31728 RVA: 0x0003AC1E File Offset: 0x00038E1E
		public unsafe Il2CppSystem.Action onReachOutput
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onReachOutput);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_onReachOutput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002552 RID: 9554
		// (get) Token: 0x06007BF1 RID: 31729 RVA: 0x00217D20 File Offset: 0x00215F20
		// (set) Token: 0x06007BF2 RID: 31730 RVA: 0x0003AC3D File Offset: 0x00038E3D
		public unsafe PackagingStation station
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_station);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_station), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002553 RID: 9555
		// (get) Token: 0x06007BF3 RID: 31731 RVA: 0x00217D50 File Offset: 0x00215F50
		// (set) Token: 0x06007BF4 RID: 31732 RVA: 0x0003AC5C File Offset: 0x00038E5C
		public unsafe Dictionary<FunctionalProduct, float> productContactTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_productContactTime);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<FunctionalProduct, float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_productContactTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002554 RID: 9556
		// (get) Token: 0x06007BF5 RID: 31733 RVA: 0x00217D80 File Offset: 0x00215F80
		// (set) Token: 0x06007BF6 RID: 31734 RVA: 0x0003AC7B File Offset: 0x00038E7B
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_VelocityCalculator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalPackaging.NativeFieldInfoPtr_VelocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005436 RID: 21558
		private static readonly System.IntPtr NativeFieldInfoPtr__IsSealed_k__BackingField;

		// Token: 0x04005437 RID: 21559
		private static readonly System.IntPtr NativeFieldInfoPtr__IsFull_k__BackingField;

		// Token: 0x04005438 RID: 21560
		private static readonly System.IntPtr NativeFieldInfoPtr__ReachedOutput_k__BackingField;

		// Token: 0x04005439 RID: 21561
		private static readonly System.IntPtr NativeFieldInfoPtr_SealInstruction;

		// Token: 0x0400543A RID: 21562
		private static readonly System.IntPtr NativeFieldInfoPtr_AutoEnableSealing;

		// Token: 0x0400543B RID: 21563
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductContactTime;

		// Token: 0x0400543C RID: 21564
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductContactMaxVelocity;

		// Token: 0x0400543D RID: 21565
		private static readonly System.IntPtr NativeFieldInfoPtr_Definition;

		// Token: 0x0400543E RID: 21566
		private static readonly System.IntPtr NativeFieldInfoPtr_AlignmentPoint;

		// Token: 0x0400543F RID: 21567
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductAlignmentPoints;

		// Token: 0x04005440 RID: 21568
		private static readonly System.IntPtr NativeFieldInfoPtr_SealSound;

		// Token: 0x04005441 RID: 21569
		private static readonly System.IntPtr NativeFieldInfoPtr_PackedProducts;

		// Token: 0x04005442 RID: 21570
		private static readonly System.IntPtr NativeFieldInfoPtr_onFullyPacked;

		// Token: 0x04005443 RID: 21571
		private static readonly System.IntPtr NativeFieldInfoPtr_onSealed;

		// Token: 0x04005444 RID: 21572
		private static readonly System.IntPtr NativeFieldInfoPtr_onReachOutput;

		// Token: 0x04005445 RID: 21573
		private static readonly System.IntPtr NativeFieldInfoPtr_station;

		// Token: 0x04005446 RID: 21574
		private static readonly System.IntPtr NativeFieldInfoPtr_productContactTime;

		// Token: 0x04005447 RID: 21575
		private static readonly System.IntPtr NativeFieldInfoPtr_VelocityCalculator;

		// Token: 0x04005448 RID: 21576
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0;

		// Token: 0x04005449 RID: 21577
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsSealed_Protected_set_Void_Boolean_0;

		// Token: 0x0400544A RID: 21578
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsFull_Public_get_Boolean_0;

		// Token: 0x0400544B RID: 21579
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsFull_Protected_set_Void_Boolean_0;

		// Token: 0x0400544C RID: 21580
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ReachedOutput_Public_get_Boolean_0;

		// Token: 0x0400544D RID: 21581
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ReachedOutput_Protected_set_Void_Boolean_0;

		// Token: 0x0400544E RID: 21582
		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_Transform_Boolean_0;

		// Token: 0x0400544F RID: 21583
		private static readonly System.IntPtr NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0;

		// Token: 0x04005450 RID: 21584
		private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0;

		// Token: 0x04005451 RID: 21585
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0;

		// Token: 0x04005452 RID: 21586
		private static readonly System.IntPtr NativeMethodInfoPtr_PackProduct_Protected_Virtual_New_Void_FunctionalProduct_0;

		// Token: 0x04005453 RID: 21587
		private static readonly System.IntPtr NativeMethodInfoPtr_FullyPacked_Protected_Virtual_New_Void_0;

		// Token: 0x04005454 RID: 21588
		private static readonly System.IntPtr NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0;

		// Token: 0x04005455 RID: 21589
		private static readonly System.IntPtr NativeMethodInfoPtr_EnableSealing_Protected_Virtual_New_Void_0;

		// Token: 0x04005456 RID: 21590
		private static readonly System.IntPtr NativeMethodInfoPtr_Seal_Public_Virtual_New_Void_0;

		// Token: 0x04005457 RID: 21591
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
