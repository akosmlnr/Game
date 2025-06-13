using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Animation;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000474 RID: 1140
	public class CameraOrbit : MonoBehaviour
	{
		// Token: 0x060061FD RID: 25085 RVA: 0x001C293C File Offset: 0x001C0B3C
		// Note: this type is marked as 'beforefieldinit'.
		static CameraOrbit()
		{
			Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "CameraOrbit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr);
			CameraOrbit.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "target");
			CameraOrbit.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "cam");
			CameraOrbit.NativeFieldInfoPtr_raycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "raycaster");
			CameraOrbit.NativeFieldInfoPtr_LookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "LookAt");
			CameraOrbit.NativeFieldInfoPtr_targetdistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "targetdistance");
			CameraOrbit.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "xSpeed");
			CameraOrbit.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "ySpeed");
			CameraOrbit.NativeFieldInfoPtr_sideOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "sideOffset");
			CameraOrbit.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "yMinLimit");
			CameraOrbit.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "yMaxLimit");
			CameraOrbit.NativeFieldInfoPtr_distanceMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "distanceMin");
			CameraOrbit.NativeFieldInfoPtr_distanceMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "distanceMax");
			CameraOrbit.NativeFieldInfoPtr_ScrollSensativity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "ScrollSensativity");
			CameraOrbit.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "rb");
			CameraOrbit.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "x");
			CameraOrbit.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "y");
			CameraOrbit.NativeFieldInfoPtr_targetx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "targetx");
			CameraOrbit.NativeFieldInfoPtr_targety = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "targety");
			CameraOrbit.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "distance");
			CameraOrbit.NativeFieldInfoPtr_hoveringUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "hoveringUI");
			CameraOrbit.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100675882);
			CameraOrbit.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100675883);
			CameraOrbit.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100675884);
			CameraOrbit.NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100675885);
			CameraOrbit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100675886);
		}

		// Token: 0x060061FE RID: 25086 RVA: 0x001C2B60 File Offset: 0x001C0D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203461, XrefRangeEnd = 203472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbit.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061FF RID: 25087 RVA: 0x001C2B94 File Offset: 0x001C0D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203472, XrefRangeEnd = 203491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbit.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006200 RID: 25088 RVA: 0x001C2BC8 File Offset: 0x001C0DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203491, XrefRangeEnd = 203553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbit.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006201 RID: 25089 RVA: 0x001C2BFC File Offset: 0x001C0DFC
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CameraOrbit.NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006202 RID: 25090 RVA: 0x001C2C58 File Offset: 0x001C0E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203553, XrefRangeEnd = 203554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraOrbit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006203 RID: 25091 RVA: 0x0002E075 File Offset: 0x0002C275
		public CameraOrbit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x06006204 RID: 25092 RVA: 0x001C2C94 File Offset: 0x001C0E94
		// (set) Token: 0x06006205 RID: 25093 RVA: 0x0002E07E File Offset: 0x0002C27E
		public unsafe Transform target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x06006206 RID: 25094 RVA: 0x001C2CC4 File Offset: 0x001C0EC4
		// (set) Token: 0x06006207 RID: 25095 RVA: 0x0002E09D File Offset: 0x0002C29D
		public unsafe Transform cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x06006208 RID: 25096 RVA: 0x001C2CF4 File Offset: 0x001C0EF4
		// (set) Token: 0x06006209 RID: 25097 RVA: 0x0002E0BC File Offset: 0x0002C2BC
		public unsafe GraphicRaycaster raycaster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_raycaster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRaycaster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_raycaster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x0600620A RID: 25098 RVA: 0x001C2D24 File Offset: 0x001C0F24
		// (set) Token: 0x0600620B RID: 25099 RVA: 0x0002E0DB File Offset: 0x0002C2DB
		public unsafe AvatarLookController LookAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_LookAt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarLookController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_LookAt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x0600620C RID: 25100 RVA: 0x001C2D54 File Offset: 0x001C0F54
		// (set) Token: 0x0600620D RID: 25101 RVA: 0x0002E0FA File Offset: 0x0002C2FA
		public unsafe float targetdistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targetdistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targetdistance)) = value;
			}
		}

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x0600620E RID: 25102 RVA: 0x001C2D7C File Offset: 0x001C0F7C
		// (set) Token: 0x0600620F RID: 25103 RVA: 0x0002E115 File Offset: 0x0002C315
		public unsafe float xSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_xSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_xSpeed)) = value;
			}
		}

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x06006210 RID: 25104 RVA: 0x001C2DA4 File Offset: 0x001C0FA4
		// (set) Token: 0x06006211 RID: 25105 RVA: 0x0002E130 File Offset: 0x0002C330
		public unsafe float ySpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_ySpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_ySpeed)) = value;
			}
		}

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x06006212 RID: 25106 RVA: 0x001C2DCC File Offset: 0x001C0FCC
		// (set) Token: 0x06006213 RID: 25107 RVA: 0x0002E14B File Offset: 0x0002C34B
		public unsafe float sideOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_sideOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_sideOffset)) = value;
			}
		}

		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x06006214 RID: 25108 RVA: 0x001C2DF4 File Offset: 0x001C0FF4
		// (set) Token: 0x06006215 RID: 25109 RVA: 0x0002E166 File Offset: 0x0002C366
		public unsafe float yMinLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_yMinLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_yMinLimit)) = value;
			}
		}

		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x06006216 RID: 25110 RVA: 0x001C2E1C File Offset: 0x001C101C
		// (set) Token: 0x06006217 RID: 25111 RVA: 0x0002E181 File Offset: 0x0002C381
		public unsafe float yMaxLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_yMaxLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_yMaxLimit)) = value;
			}
		}

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x06006218 RID: 25112 RVA: 0x001C2E44 File Offset: 0x001C1044
		// (set) Token: 0x06006219 RID: 25113 RVA: 0x0002E19C File Offset: 0x0002C39C
		public unsafe float distanceMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distanceMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distanceMin)) = value;
			}
		}

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x0600621A RID: 25114 RVA: 0x001C2E6C File Offset: 0x001C106C
		// (set) Token: 0x0600621B RID: 25115 RVA: 0x0002E1B7 File Offset: 0x0002C3B7
		public unsafe float distanceMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distanceMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distanceMax)) = value;
			}
		}

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x0600621C RID: 25116 RVA: 0x001C2E94 File Offset: 0x001C1094
		// (set) Token: 0x0600621D RID: 25117 RVA: 0x0002E1D2 File Offset: 0x0002C3D2
		public unsafe float ScrollSensativity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_ScrollSensativity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_ScrollSensativity)) = value;
			}
		}

		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x0600621E RID: 25118 RVA: 0x001C2EBC File Offset: 0x001C10BC
		// (set) Token: 0x0600621F RID: 25119 RVA: 0x0002E1ED File Offset: 0x0002C3ED
		public unsafe Rigidbody rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x06006220 RID: 25120 RVA: 0x001C2EEC File Offset: 0x001C10EC
		// (set) Token: 0x06006221 RID: 25121 RVA: 0x0002E20C File Offset: 0x0002C40C
		public unsafe float x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x06006222 RID: 25122 RVA: 0x001C2F14 File Offset: 0x001C1114
		// (set) Token: 0x06006223 RID: 25123 RVA: 0x0002E227 File Offset: 0x0002C427
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x06006224 RID: 25124 RVA: 0x001C2F3C File Offset: 0x001C113C
		// (set) Token: 0x06006225 RID: 25125 RVA: 0x0002E242 File Offset: 0x0002C442
		public unsafe float targetx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targetx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targetx)) = value;
			}
		}

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x06006226 RID: 25126 RVA: 0x001C2F64 File Offset: 0x001C1164
		// (set) Token: 0x06006227 RID: 25127 RVA: 0x0002E25D File Offset: 0x0002C45D
		public unsafe float targety
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targety);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targety)) = value;
			}
		}

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x06006228 RID: 25128 RVA: 0x001C2F8C File Offset: 0x001C118C
		// (set) Token: 0x06006229 RID: 25129 RVA: 0x0002E278 File Offset: 0x0002C478
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x0600622A RID: 25130 RVA: 0x001C2FB4 File Offset: 0x001C11B4
		// (set) Token: 0x0600622B RID: 25131 RVA: 0x0002E293 File Offset: 0x0002C493
		public unsafe bool hoveringUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_hoveringUI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_hoveringUI)) = value;
			}
		}

		// Token: 0x040042F0 RID: 17136
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x040042F1 RID: 17137
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x040042F2 RID: 17138
		private static readonly IntPtr NativeFieldInfoPtr_raycaster;

		// Token: 0x040042F3 RID: 17139
		private static readonly IntPtr NativeFieldInfoPtr_LookAt;

		// Token: 0x040042F4 RID: 17140
		private static readonly IntPtr NativeFieldInfoPtr_targetdistance;

		// Token: 0x040042F5 RID: 17141
		private static readonly IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x040042F6 RID: 17142
		private static readonly IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x040042F7 RID: 17143
		private static readonly IntPtr NativeFieldInfoPtr_sideOffset;

		// Token: 0x040042F8 RID: 17144
		private static readonly IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x040042F9 RID: 17145
		private static readonly IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x040042FA RID: 17146
		private static readonly IntPtr NativeFieldInfoPtr_distanceMin;

		// Token: 0x040042FB RID: 17147
		private static readonly IntPtr NativeFieldInfoPtr_distanceMax;

		// Token: 0x040042FC RID: 17148
		private static readonly IntPtr NativeFieldInfoPtr_ScrollSensativity;

		// Token: 0x040042FD RID: 17149
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x040042FE RID: 17150
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040042FF RID: 17151
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04004300 RID: 17152
		private static readonly IntPtr NativeFieldInfoPtr_targetx;

		// Token: 0x04004301 RID: 17153
		private static readonly IntPtr NativeFieldInfoPtr_targety;

		// Token: 0x04004302 RID: 17154
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x04004303 RID: 17155
		private static readonly IntPtr NativeFieldInfoPtr_hoveringUI;

		// Token: 0x04004304 RID: 17156
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004305 RID: 17157
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004306 RID: 17158
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04004307 RID: 17159
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04004308 RID: 17160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
