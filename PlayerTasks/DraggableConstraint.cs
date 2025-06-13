using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200020D RID: 525
	public class DraggableConstraint : MonoBehaviour
	{
		// Token: 0x06002AE2 RID: 10978 RVA: 0x000FB598 File Offset: 0x000F9798
		// Note: this type is marked as 'beforefieldinit'.
		static DraggableConstraint()
		{
			Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "DraggableConstraint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr);
			DraggableConstraint.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "Container");
			DraggableConstraint.NativeFieldInfoPtr_Anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "Anchor");
			DraggableConstraint.NativeFieldInfoPtr_ProportionalZClamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "ProportionalZClamp");
			DraggableConstraint.NativeFieldInfoPtr_AlignUpToContainerPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "AlignUpToContainerPlane");
			DraggableConstraint.NativeFieldInfoPtr_ClampUpDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "ClampUpDirection");
			DraggableConstraint.NativeFieldInfoPtr_UpDirectionMaxDifference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "UpDirectionMaxDifference");
			DraggableConstraint.NativeFieldInfoPtr_startLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "startLocalPos");
			DraggableConstraint.NativeFieldInfoPtr_draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "draggable");
			DraggableConstraint.NativeFieldInfoPtr_joint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "joint");
			DraggableConstraint.NativeMethodInfoPtr_get_RelativePos_Private_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668171);
			DraggableConstraint.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668172);
			DraggableConstraint.NativeMethodInfoPtr_SetContainer_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668173);
			DraggableConstraint.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668174);
			DraggableConstraint.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668175);
			DraggableConstraint.NativeMethodInfoPtr_ProportionalClamp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668176);
			DraggableConstraint.NativeMethodInfoPtr_LockRotationX_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668177);
			DraggableConstraint.NativeMethodInfoPtr_LockRotationY_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668178);
			DraggableConstraint.NativeMethodInfoPtr_AlignToContainerPlane_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668179);
			DraggableConstraint.NativeMethodInfoPtr_ClampUpRot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668180);
			DraggableConstraint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668181);
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06002AE3 RID: 10979 RVA: 0x000FB758 File Offset: 0x000F9958
		public unsafe Vector3 RelativePos
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 123965, RefRangeEnd = 123967, XrefRangeStart = 123955, XrefRangeEnd = 123965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_get_RelativePos_Private_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x000FB794 File Offset: 0x000F9994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123967, XrefRangeEnd = 123999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x000FB7C8 File Offset: 0x000F99C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 124019, RefRangeEnd = 124022, XrefRangeStart = 123999, XrefRangeEnd = 124019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContainer(Transform container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_SetContainer_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x000FB80C File Offset: 0x000F9A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124022, XrefRangeEnd = 124023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableConstraint.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x000FB848 File Offset: 0x000F9A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124023, XrefRangeEnd = 124038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableConstraint.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x000FB884 File Offset: 0x000F9A84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124050, RefRangeEnd = 124051, XrefRangeStart = 124038, XrefRangeEnd = 124050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProportionalClamp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_ProportionalClamp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x000FB8B8 File Offset: 0x000F9AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124051, XrefRangeEnd = 124061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LockRotationX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_LockRotationX_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x000FB8EC File Offset: 0x000F9AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124061, XrefRangeEnd = 124071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LockRotationY()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_LockRotationY_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x000FB920 File Offset: 0x000F9B20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124086, RefRangeEnd = 124087, XrefRangeStart = 124071, XrefRangeEnd = 124086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignToContainerPlane()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_AlignToContainerPlane_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x000FB954 File Offset: 0x000F9B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124087, XrefRangeEnd = 124101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampUpRot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_ClampUpRot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x000FB988 File Offset: 0x000F9B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124101, XrefRangeEnd = 124102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DraggableConstraint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x000171AE File Offset: 0x000153AE
		public DraggableConstraint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06002AEF RID: 10991 RVA: 0x000FB9C4 File Offset: 0x000F9BC4
		// (set) Token: 0x06002AF0 RID: 10992 RVA: 0x000171B7 File Offset: 0x000153B7
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x000FB9F4 File Offset: 0x000F9BF4
		// (set) Token: 0x06002AF2 RID: 10994 RVA: 0x000171D6 File Offset: 0x000153D6
		public unsafe Rigidbody Anchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_Anchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_Anchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06002AF3 RID: 10995 RVA: 0x000FBA24 File Offset: 0x000F9C24
		// (set) Token: 0x06002AF4 RID: 10996 RVA: 0x000171F5 File Offset: 0x000153F5
		public unsafe bool ProportionalZClamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_ProportionalZClamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_ProportionalZClamp)) = value;
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x000FBA4C File Offset: 0x000F9C4C
		// (set) Token: 0x06002AF6 RID: 10998 RVA: 0x00017210 File Offset: 0x00015410
		public unsafe bool AlignUpToContainerPlane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_AlignUpToContainerPlane);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_AlignUpToContainerPlane)) = value;
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x000FBA74 File Offset: 0x000F9C74
		// (set) Token: 0x06002AF8 RID: 11000 RVA: 0x0001722B File Offset: 0x0001542B
		public unsafe bool ClampUpDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_ClampUpDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_ClampUpDirection)) = value;
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06002AF9 RID: 11001 RVA: 0x000FBA9C File Offset: 0x000F9C9C
		// (set) Token: 0x06002AFA RID: 11002 RVA: 0x00017246 File Offset: 0x00015446
		public unsafe float UpDirectionMaxDifference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_UpDirectionMaxDifference);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_UpDirectionMaxDifference)) = value;
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06002AFB RID: 11003 RVA: 0x000FBAC4 File Offset: 0x000F9CC4
		// (set) Token: 0x06002AFC RID: 11004 RVA: 0x00017261 File Offset: 0x00015461
		public unsafe Vector3 startLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_startLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_startLocalPos)) = value;
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06002AFD RID: 11005 RVA: 0x000FBAEC File Offset: 0x000F9CEC
		// (set) Token: 0x06002AFE RID: 11006 RVA: 0x0001727C File Offset: 0x0001547C
		public unsafe Draggable draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06002AFF RID: 11007 RVA: 0x000FBB1C File Offset: 0x000F9D1C
		// (set) Token: 0x06002B00 RID: 11008 RVA: 0x0001729B File Offset: 0x0001549B
		public unsafe ConfigurableJoint joint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_joint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurableJoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_joint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C77 RID: 7287
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04001C78 RID: 7288
		private static readonly IntPtr NativeFieldInfoPtr_Anchor;

		// Token: 0x04001C79 RID: 7289
		private static readonly IntPtr NativeFieldInfoPtr_ProportionalZClamp;

		// Token: 0x04001C7A RID: 7290
		private static readonly IntPtr NativeFieldInfoPtr_AlignUpToContainerPlane;

		// Token: 0x04001C7B RID: 7291
		private static readonly IntPtr NativeFieldInfoPtr_ClampUpDirection;

		// Token: 0x04001C7C RID: 7292
		private static readonly IntPtr NativeFieldInfoPtr_UpDirectionMaxDifference;

		// Token: 0x04001C7D RID: 7293
		private static readonly IntPtr NativeFieldInfoPtr_startLocalPos;

		// Token: 0x04001C7E RID: 7294
		private static readonly IntPtr NativeFieldInfoPtr_draggable;

		// Token: 0x04001C7F RID: 7295
		private static readonly IntPtr NativeFieldInfoPtr_joint;

		// Token: 0x04001C80 RID: 7296
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativePos_Private_get_Vector3_0;

		// Token: 0x04001C81 RID: 7297
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001C82 RID: 7298
		private static readonly IntPtr NativeMethodInfoPtr_SetContainer_Public_Void_Transform_0;

		// Token: 0x04001C83 RID: 7299
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001C84 RID: 7300
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001C85 RID: 7301
		private static readonly IntPtr NativeMethodInfoPtr_ProportionalClamp_Private_Void_0;

		// Token: 0x04001C86 RID: 7302
		private static readonly IntPtr NativeMethodInfoPtr_LockRotationX_Private_Void_0;

		// Token: 0x04001C87 RID: 7303
		private static readonly IntPtr NativeMethodInfoPtr_LockRotationY_Private_Void_0;

		// Token: 0x04001C88 RID: 7304
		private static readonly IntPtr NativeMethodInfoPtr_AlignToContainerPlane_Private_Void_0;

		// Token: 0x04001C89 RID: 7305
		private static readonly IntPtr NativeMethodInfoPtr_ClampUpRot_Private_Void_0;

		// Token: 0x04001C8A RID: 7306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
