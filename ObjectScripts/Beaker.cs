using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.StationFramework;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200076A RID: 1898
	public class Beaker : StationItem
	{
		// Token: 0x0600AEC5 RID: 44741 RVA: 0x002BC19C File Offset: 0x002BA39C
		// Note: this type is marked as 'beforefieldinit'.
		static Beaker()
		{
			Il2CppClassPointerStore<Beaker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Beaker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Beaker>.NativeClassPtr);
			Beaker.NativeFieldInfoPtr_ClampAngle_MaxLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "ClampAngle_MaxLiquid");
			Beaker.NativeFieldInfoPtr_ClampAngle_MinLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "ClampAngle_MinLiquid");
			Beaker.NativeFieldInfoPtr_AngleToPour_MaxLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "AngleToPour_MaxLiquid");
			Beaker.NativeFieldInfoPtr_AngleToPour_MinLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "AngleToPour_MinLiquid");
			Beaker.NativeFieldInfoPtr_Draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Draggable");
			Beaker.NativeFieldInfoPtr_Constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Constraint");
			Beaker.NativeFieldInfoPtr_ConcaveCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "ConcaveCollider");
			Beaker.NativeFieldInfoPtr_ConvexCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "ConvexCollider");
			Beaker.NativeFieldInfoPtr_CenterOfMass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "CenterOfMass");
			Beaker.NativeFieldInfoPtr_Joint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Joint");
			Beaker.NativeFieldInfoPtr_Anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Anchor");
			Beaker.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Container");
			Beaker.NativeFieldInfoPtr_Fillable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Fillable");
			Beaker.NativeFieldInfoPtr_Pourable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Pourable");
			Beaker.NativeFieldInfoPtr_FilterPaper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "FilterPaper");
			Beaker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Beaker>.NativeClassPtr, 100684877);
			Beaker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Beaker>.NativeClassPtr, 100684878);
			Beaker.NativeMethodInfoPtr_SetStatic_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Beaker>.NativeClassPtr, 100684879);
			Beaker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Beaker>.NativeClassPtr, 100684880);
		}

		// Token: 0x0600AEC6 RID: 44742 RVA: 0x002BC348 File Offset: 0x002BA548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302887, XrefRangeEnd = 302892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Beaker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AEC7 RID: 44743 RVA: 0x002BC37C File Offset: 0x002BA57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302892, XrefRangeEnd = 302897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Beaker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AEC8 RID: 44744 RVA: 0x002BC3B0 File Offset: 0x002BA5B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302901, RefRangeEnd = 302902, XrefRangeStart = 302897, XrefRangeEnd = 302901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStatic(bool stat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stat;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Beaker.NativeMethodInfoPtr_SetStatic_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AEC9 RID: 44745 RVA: 0x002BC3F0 File Offset: 0x002BA5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302902, XrefRangeEnd = 302903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Beaker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Beaker>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Beaker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AECA RID: 44746 RVA: 0x00055B22 File Offset: 0x00053D22
		public Beaker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170035D4 RID: 13780
		// (get) Token: 0x0600AECB RID: 44747 RVA: 0x002BC42C File Offset: 0x002BA62C
		// (set) Token: 0x0600AECC RID: 44748 RVA: 0x00055B2B File Offset: 0x00053D2B
		public unsafe float ClampAngle_MaxLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ClampAngle_MaxLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ClampAngle_MaxLiquid)) = value;
			}
		}

		// Token: 0x170035D5 RID: 13781
		// (get) Token: 0x0600AECD RID: 44749 RVA: 0x002BC454 File Offset: 0x002BA654
		// (set) Token: 0x0600AECE RID: 44750 RVA: 0x00055B46 File Offset: 0x00053D46
		public unsafe float ClampAngle_MinLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ClampAngle_MinLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ClampAngle_MinLiquid)) = value;
			}
		}

		// Token: 0x170035D6 RID: 13782
		// (get) Token: 0x0600AECF RID: 44751 RVA: 0x002BC47C File Offset: 0x002BA67C
		// (set) Token: 0x0600AED0 RID: 44752 RVA: 0x00055B61 File Offset: 0x00053D61
		public unsafe float AngleToPour_MaxLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_AngleToPour_MaxLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_AngleToPour_MaxLiquid)) = value;
			}
		}

		// Token: 0x170035D7 RID: 13783
		// (get) Token: 0x0600AED1 RID: 44753 RVA: 0x002BC4A4 File Offset: 0x002BA6A4
		// (set) Token: 0x0600AED2 RID: 44754 RVA: 0x00055B7C File Offset: 0x00053D7C
		public unsafe float AngleToPour_MinLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_AngleToPour_MinLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_AngleToPour_MinLiquid)) = value;
			}
		}

		// Token: 0x170035D8 RID: 13784
		// (get) Token: 0x0600AED3 RID: 44755 RVA: 0x002BC4CC File Offset: 0x002BA6CC
		// (set) Token: 0x0600AED4 RID: 44756 RVA: 0x00055B97 File Offset: 0x00053D97
		public unsafe Draggable Draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D9 RID: 13785
		// (get) Token: 0x0600AED5 RID: 44757 RVA: 0x002BC4FC File Offset: 0x002BA6FC
		// (set) Token: 0x0600AED6 RID: 44758 RVA: 0x00055BB6 File Offset: 0x00053DB6
		public unsafe DraggableConstraint Constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Constraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Constraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035DA RID: 13786
		// (get) Token: 0x0600AED7 RID: 44759 RVA: 0x002BC52C File Offset: 0x002BA72C
		// (set) Token: 0x0600AED8 RID: 44760 RVA: 0x00055BD5 File Offset: 0x00053DD5
		public unsafe Collider ConcaveCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ConcaveCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ConcaveCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035DB RID: 13787
		// (get) Token: 0x0600AED9 RID: 44761 RVA: 0x002BC55C File Offset: 0x002BA75C
		// (set) Token: 0x0600AEDA RID: 44762 RVA: 0x00055BF4 File Offset: 0x00053DF4
		public unsafe Collider ConvexCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ConvexCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ConvexCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035DC RID: 13788
		// (get) Token: 0x0600AEDB RID: 44763 RVA: 0x002BC58C File Offset: 0x002BA78C
		// (set) Token: 0x0600AEDC RID: 44764 RVA: 0x00055C13 File Offset: 0x00053E13
		public unsafe Transform CenterOfMass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_CenterOfMass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_CenterOfMass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035DD RID: 13789
		// (get) Token: 0x0600AEDD RID: 44765 RVA: 0x002BC5BC File Offset: 0x002BA7BC
		// (set) Token: 0x0600AEDE RID: 44766 RVA: 0x00055C32 File Offset: 0x00053E32
		public unsafe ConfigurableJoint Joint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Joint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurableJoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Joint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035DE RID: 13790
		// (get) Token: 0x0600AEDF RID: 44767 RVA: 0x002BC5EC File Offset: 0x002BA7EC
		// (set) Token: 0x0600AEE0 RID: 44768 RVA: 0x00055C51 File Offset: 0x00053E51
		public unsafe Rigidbody Anchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Anchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Anchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035DF RID: 13791
		// (get) Token: 0x0600AEE1 RID: 44769 RVA: 0x002BC61C File Offset: 0x002BA81C
		// (set) Token: 0x0600AEE2 RID: 44770 RVA: 0x00055C70 File Offset: 0x00053E70
		public unsafe LiquidContainer Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035E0 RID: 13792
		// (get) Token: 0x0600AEE3 RID: 44771 RVA: 0x002BC64C File Offset: 0x002BA84C
		// (set) Token: 0x0600AEE4 RID: 44772 RVA: 0x00055C8F File Offset: 0x00053E8F
		public unsafe Fillable Fillable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Fillable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Fillable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Fillable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035E1 RID: 13793
		// (get) Token: 0x0600AEE5 RID: 44773 RVA: 0x002BC67C File Offset: 0x002BA87C
		// (set) Token: 0x0600AEE6 RID: 44774 RVA: 0x00055CAE File Offset: 0x00053EAE
		public unsafe PourableModule Pourable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Pourable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PourableModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Pourable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035E2 RID: 13794
		// (get) Token: 0x0600AEE7 RID: 44775 RVA: 0x002BC6AC File Offset: 0x002BA8AC
		// (set) Token: 0x0600AEE8 RID: 44776 RVA: 0x00055CCD File Offset: 0x00053ECD
		public unsafe GameObject FilterPaper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_FilterPaper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_FilterPaper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007582 RID: 30082
		private static readonly IntPtr NativeFieldInfoPtr_ClampAngle_MaxLiquid;

		// Token: 0x04007583 RID: 30083
		private static readonly IntPtr NativeFieldInfoPtr_ClampAngle_MinLiquid;

		// Token: 0x04007584 RID: 30084
		private static readonly IntPtr NativeFieldInfoPtr_AngleToPour_MaxLiquid;

		// Token: 0x04007585 RID: 30085
		private static readonly IntPtr NativeFieldInfoPtr_AngleToPour_MinLiquid;

		// Token: 0x04007586 RID: 30086
		private static readonly IntPtr NativeFieldInfoPtr_Draggable;

		// Token: 0x04007587 RID: 30087
		private static readonly IntPtr NativeFieldInfoPtr_Constraint;

		// Token: 0x04007588 RID: 30088
		private static readonly IntPtr NativeFieldInfoPtr_ConcaveCollider;

		// Token: 0x04007589 RID: 30089
		private static readonly IntPtr NativeFieldInfoPtr_ConvexCollider;

		// Token: 0x0400758A RID: 30090
		private static readonly IntPtr NativeFieldInfoPtr_CenterOfMass;

		// Token: 0x0400758B RID: 30091
		private static readonly IntPtr NativeFieldInfoPtr_Joint;

		// Token: 0x0400758C RID: 30092
		private static readonly IntPtr NativeFieldInfoPtr_Anchor;

		// Token: 0x0400758D RID: 30093
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x0400758E RID: 30094
		private static readonly IntPtr NativeFieldInfoPtr_Fillable;

		// Token: 0x0400758F RID: 30095
		private static readonly IntPtr NativeFieldInfoPtr_Pourable;

		// Token: 0x04007590 RID: 30096
		private static readonly IntPtr NativeFieldInfoPtr_FilterPaper;

		// Token: 0x04007591 RID: 30097
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007592 RID: 30098
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007593 RID: 30099
		private static readonly IntPtr NativeMethodInfoPtr_SetStatic_Public_Void_Boolean_0;

		// Token: 0x04007594 RID: 30100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
