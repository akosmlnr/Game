using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002FC RID: 764
	public class NPCSpeedController : MonoBehaviour
	{
		// Token: 0x0600376F RID: 14191 RVA: 0x001268A4 File Offset: 0x00124AA4
		// Note: this type is marked as 'beforefieldinit'.
		static NPCSpeedController()
		{
			Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCSpeedController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr);
			NPCSpeedController.NativeFieldInfoPtr_DefaultWalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "DefaultWalkSpeed");
			NPCSpeedController.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "SpeedMultiplier");
			NPCSpeedController.NativeFieldInfoPtr_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "Movement");
			NPCSpeedController.NativeFieldInfoPtr_speedControlStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "speedControlStack");
			NPCSpeedController.NativeFieldInfoPtr_ActiveSpeedControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "ActiveSpeedControl");
			NPCSpeedController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669677);
			NPCSpeedController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669678);
			NPCSpeedController.NativeMethodInfoPtr_GetHighestPriorityControl_Private_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669679);
			NPCSpeedController.NativeMethodInfoPtr_AddSpeedControl_Public_Void_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669680);
			NPCSpeedController.NativeMethodInfoPtr_GetSpeedControl_Public_SpeedControl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669681);
			NPCSpeedController.NativeMethodInfoPtr_DoesSpeedControlExist_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669682);
			NPCSpeedController.NativeMethodInfoPtr_RemoveSpeedControl_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669683);
			NPCSpeedController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669684);
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x001269D8 File Offset: 0x00124BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143760, XrefRangeEnd = 143768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003771 RID: 14193 RVA: 0x00126A0C File Offset: 0x00124C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143768, XrefRangeEnd = 143782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003772 RID: 14194 RVA: 0x00126A40 File Offset: 0x00124C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143782, XrefRangeEnd = 143786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSpeedController.SpeedControl GetHighestPriorityControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_GetHighestPriorityControl_Private_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSpeedController.SpeedControl>(intPtr2) : null;
		}

		// Token: 0x06003773 RID: 14195 RVA: 0x00126A80 File Offset: 0x00124C80
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 143809, RefRangeEnd = 143831, XrefRangeStart = 143786, XrefRangeEnd = 143809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSpeedControl(NPCSpeedController.SpeedControl control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(control);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_AddSpeedControl_Public_Void_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x00126AC4 File Offset: 0x00124CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143831, XrefRangeEnd = 143846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSpeedController.SpeedControl GetSpeedControl(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_GetSpeedControl_Public_SpeedControl_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSpeedController.SpeedControl>(intPtr2) : null;
		}

		// Token: 0x06003775 RID: 14197 RVA: 0x00126B14 File Offset: 0x00124D14
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 143860, RefRangeEnd = 143867, XrefRangeStart = 143846, XrefRangeEnd = 143860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesSpeedControlExist(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_DoesSpeedControlExist_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x00126B64 File Offset: 0x00124D64
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 143884, RefRangeEnd = 143901, XrefRangeStart = 143867, XrefRangeEnd = 143884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSpeedControl(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_RemoveSpeedControl_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003777 RID: 14199 RVA: 0x00126BA8 File Offset: 0x00124DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143901, XrefRangeEnd = 143909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSpeedController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x0001CDC0 File Offset: 0x0001AFC0
		public NPCSpeedController(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x06003779 RID: 14201 RVA: 0x00126BE4 File Offset: 0x00124DE4
		// (set) Token: 0x0600377A RID: 14202 RVA: 0x0001CDC9 File Offset: 0x0001AFC9
		public unsafe float DefaultWalkSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_DefaultWalkSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_DefaultWalkSpeed)) = value;
			}
		}

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x0600377B RID: 14203 RVA: 0x00126C0C File Offset: 0x00124E0C
		// (set) Token: 0x0600377C RID: 14204 RVA: 0x0001CDE4 File Offset: 0x0001AFE4
		public unsafe float SpeedMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x0600377D RID: 14205 RVA: 0x00126C34 File Offset: 0x00124E34
		// (set) Token: 0x0600377E RID: 14206 RVA: 0x0001CDFF File Offset: 0x0001AFFF
		public unsafe NPCMovement Movement
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_Movement);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCMovement>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_Movement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x0600377F RID: 14207 RVA: 0x00126C64 File Offset: 0x00124E64
		// (set) Token: 0x06003780 RID: 14208 RVA: 0x0001CE1E File Offset: 0x0001B01E
		public unsafe List<NPCSpeedController.SpeedControl> speedControlStack
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_speedControlStack);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCSpeedController.SpeedControl>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_speedControlStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x06003781 RID: 14209 RVA: 0x00126C94 File Offset: 0x00124E94
		// (set) Token: 0x06003782 RID: 14210 RVA: 0x0001CE3D File Offset: 0x0001B03D
		public unsafe NPCSpeedController.SpeedControl ActiveSpeedControl
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_ActiveSpeedControl);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSpeedController.SpeedControl>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_ActiveSpeedControl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002441 RID: 9281
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultWalkSpeed;

		// Token: 0x04002442 RID: 9282
		private static readonly System.IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x04002443 RID: 9283
		private static readonly System.IntPtr NativeFieldInfoPtr_Movement;

		// Token: 0x04002444 RID: 9284
		private static readonly System.IntPtr NativeFieldInfoPtr_speedControlStack;

		// Token: 0x04002445 RID: 9285
		private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSpeedControl;

		// Token: 0x04002446 RID: 9286
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002447 RID: 9287
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04002448 RID: 9288
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHighestPriorityControl_Private_SpeedControl_0;

		// Token: 0x04002449 RID: 9289
		private static readonly System.IntPtr NativeMethodInfoPtr_AddSpeedControl_Public_Void_SpeedControl_0;

		// Token: 0x0400244A RID: 9290
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSpeedControl_Public_SpeedControl_String_0;

		// Token: 0x0400244B RID: 9291
		private static readonly System.IntPtr NativeMethodInfoPtr_DoesSpeedControlExist_Public_Boolean_String_0;

		// Token: 0x0400244C RID: 9292
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveSpeedControl_Public_Void_String_0;

		// Token: 0x0400244D RID: 9293
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000972 RID: 2418
		[System.Serializable]
		public class SpeedControl : Il2CppSystem.Object
		{
			// Token: 0x0600CB99 RID: 52121 RVA: 0x00318E40 File Offset: 0x00317040
			// Note: this type is marked as 'beforefieldinit'.
			static SpeedControl()
			{
				Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "SpeedControl");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr);
				NPCSpeedController.SpeedControl.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr, "id");
				NPCSpeedController.SpeedControl.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr, "priority");
				NPCSpeedController.SpeedControl.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr, "speed");
				NPCSpeedController.SpeedControl.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr, 100669685);
			}

			// Token: 0x0600CB9A RID: 52122 RVA: 0x00318EBC File Offset: 0x003170BC
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 143711, RefRangeEnd = 143730, XrefRangeStart = 143709, XrefRangeEnd = 143711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpeedControl(string id, int priority, float speed) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref priority;
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref speed;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.SpeedControl.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CB9B RID: 52123 RVA: 0x00062C9B File Offset: 0x00060E9B
			public SpeedControl(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F1F RID: 16159
			// (get) Token: 0x0600CB9C RID: 52124 RVA: 0x00318F24 File Offset: 0x00317124
			// (set) Token: 0x0600CB9D RID: 52125 RVA: 0x00062CA4 File Offset: 0x00060EA4
			public unsafe string id
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F20 RID: 16160
			// (get) Token: 0x0600CB9E RID: 52126 RVA: 0x00318F4C File Offset: 0x0031714C
			// (set) Token: 0x0600CB9F RID: 52127 RVA: 0x00062CC3 File Offset: 0x00060EC3
			public unsafe int priority
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_priority)) = value;
				}
			}

			// Token: 0x17003F21 RID: 16161
			// (get) Token: 0x0600CBA0 RID: 52128 RVA: 0x00318F74 File Offset: 0x00317174
			// (set) Token: 0x0600CBA1 RID: 52129 RVA: 0x00062CDE File Offset: 0x00060EDE
			public unsafe float speed
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_speed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_speed)) = value;
				}
			}

			// Token: 0x040089DF RID: 35295
			private static readonly System.IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040089E0 RID: 35296
			private static readonly System.IntPtr NativeFieldInfoPtr_priority;

			// Token: 0x040089E1 RID: 35297
			private static readonly System.IntPtr NativeFieldInfoPtr_speed;

			// Token: 0x040089E2 RID: 35298
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0;
		}

		// Token: 0x02000973 RID: 2419
		[ObfuscatedName("ScheduleOne.NPCs.NPCSpeedController+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CBA2 RID: 52130 RVA: 0x00318F9C File Offset: 0x0031719C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass10_0>.NativeClassPtr);
				NPCSpeedController.__c__DisplayClass10_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass10_0>.NativeClassPtr, "id");
				NPCSpeedController.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass10_0>.NativeClassPtr, 100669686);
				NPCSpeedController.__c__DisplayClass10_0.NativeMethodInfoPtr__GetSpeedControl_b__0_Internal_Boolean_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass10_0>.NativeClassPtr, 100669687);
			}

			// Token: 0x0600CBA3 RID: 52131 RVA: 0x00319004 File Offset: 0x00317204
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass10_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CBA4 RID: 52132 RVA: 0x00319040 File Offset: 0x00317240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSpeedControl_b__0(NPCSpeedController.SpeedControl x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass10_0.NativeMethodInfoPtr__GetSpeedControl_b__0_Internal_Boolean_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CBA5 RID: 52133 RVA: 0x00062CF9 File Offset: 0x00060EF9
			public __c__DisplayClass10_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F22 RID: 16162
			// (get) Token: 0x0600CBA6 RID: 52134 RVA: 0x00319090 File Offset: 0x00317290
			// (set) Token: 0x0600CBA7 RID: 52135 RVA: 0x00062D02 File Offset: 0x00060F02
			public unsafe string id
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass10_0.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass10_0.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040089E3 RID: 35299
			private static readonly System.IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040089E4 RID: 35300
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089E5 RID: 35301
			private static readonly System.IntPtr NativeMethodInfoPtr__GetSpeedControl_b__0_Internal_Boolean_SpeedControl_0;
		}

		// Token: 0x02000974 RID: 2420
		[ObfuscatedName("ScheduleOne.NPCs.NPCSpeedController+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CBA8 RID: 52136 RVA: 0x003190B8 File Offset: 0x003172B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr);
				NPCSpeedController.__c__DisplayClass12_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr, "id");
				NPCSpeedController.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr, 100669688);
				NPCSpeedController.__c__DisplayClass12_0.NativeMethodInfoPtr__RemoveSpeedControl_b__0_Internal_Boolean_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr, 100669689);
			}

			// Token: 0x0600CBA9 RID: 52137 RVA: 0x00319120 File Offset: 0x00317320
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CBAA RID: 52138 RVA: 0x0031915C File Offset: 0x0031735C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveSpeedControl_b__0(NPCSpeedController.SpeedControl x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass12_0.NativeMethodInfoPtr__RemoveSpeedControl_b__0_Internal_Boolean_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CBAB RID: 52139 RVA: 0x00062D21 File Offset: 0x00060F21
			public __c__DisplayClass12_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F23 RID: 16163
			// (get) Token: 0x0600CBAC RID: 52140 RVA: 0x003191AC File Offset: 0x003173AC
			// (set) Token: 0x0600CBAD RID: 52141 RVA: 0x00062D2A File Offset: 0x00060F2A
			public unsafe string id
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass12_0.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass12_0.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040089E6 RID: 35302
			private static readonly System.IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040089E7 RID: 35303
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089E8 RID: 35304
			private static readonly System.IntPtr NativeMethodInfoPtr__RemoveSpeedControl_b__0_Internal_Boolean_SpeedControl_0;
		}

		// Token: 0x02000975 RID: 2421
		[ObfuscatedName("ScheduleOne.NPCs.NPCSpeedController+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CBAE RID: 52142 RVA: 0x003191D4 File Offset: 0x003173D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass9_0>.NativeClassPtr);
				NPCSpeedController.__c__DisplayClass9_0.NativeFieldInfoPtr_control = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass9_0>.NativeClassPtr, "control");
				NPCSpeedController.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass9_0>.NativeClassPtr, 100669690);
				NPCSpeedController.__c__DisplayClass9_0.NativeMethodInfoPtr__AddSpeedControl_b__0_Internal_Boolean_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass9_0>.NativeClassPtr, 100669691);
			}

			// Token: 0x0600CBAF RID: 52143 RVA: 0x0031923C File Offset: 0x0031743C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass9_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CBB0 RID: 52144 RVA: 0x00319278 File Offset: 0x00317478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143730, XrefRangeEnd = 143760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddSpeedControl_b__0(NPCSpeedController.SpeedControl x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass9_0.NativeMethodInfoPtr__AddSpeedControl_b__0_Internal_Boolean_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CBB1 RID: 52145 RVA: 0x00062D49 File Offset: 0x00060F49
			public __c__DisplayClass9_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F24 RID: 16164
			// (get) Token: 0x0600CBB2 RID: 52146 RVA: 0x003192C8 File Offset: 0x003174C8
			// (set) Token: 0x0600CBB3 RID: 52147 RVA: 0x00062D52 File Offset: 0x00060F52
			public unsafe NPCSpeedController.SpeedControl control
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass9_0.NativeFieldInfoPtr_control);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSpeedController.SpeedControl>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass9_0.NativeFieldInfoPtr_control), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089E9 RID: 35305
			private static readonly System.IntPtr NativeFieldInfoPtr_control;

			// Token: 0x040089EA RID: 35306
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089EB RID: 35307
			private static readonly System.IntPtr NativeMethodInfoPtr__AddSpeedControl_b__0_Internal_Boolean_SpeedControl_0;
		}
	}
}
