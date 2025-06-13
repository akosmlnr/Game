using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020007AD RID: 1965
	public class NPCPresenceAccessZone : AccessZone
	{
		// Token: 0x0600B9D3 RID: 47571 RVA: 0x002E5768 File Offset: 0x002E3968
		// Note: this type is marked as 'beforefieldinit'.
		static NPCPresenceAccessZone()
		{
			Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "NPCPresenceAccessZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr);
			NPCPresenceAccessZone.NativeFieldInfoPtr_CooldownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, "CooldownTime");
			NPCPresenceAccessZone.NativeFieldInfoPtr_DetectionZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, "DetectionZone");
			NPCPresenceAccessZone.NativeFieldInfoPtr_TargetNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, "TargetNPC");
			NPCPresenceAccessZone.NativeFieldInfoPtr_timeSinceNPCSensed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, "timeSinceNPCSensed");
			NPCPresenceAccessZone.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, 100686291);
			NPCPresenceAccessZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, 100686292);
			NPCPresenceAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, 100686293);
			NPCPresenceAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr, 100686294);
		}

		// Token: 0x0600B9D4 RID: 47572 RVA: 0x002E5838 File Offset: 0x002E3A38
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCPresenceAccessZone.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9D5 RID: 47573 RVA: 0x002E5874 File Offset: 0x002E3A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316733, XrefRangeEnd = 316749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCPresenceAccessZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9D6 RID: 47574 RVA: 0x002E58B0 File Offset: 0x002E3AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316749, XrefRangeEnd = 316756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCPresenceAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9D7 RID: 47575 RVA: 0x002E58EC File Offset: 0x002E3AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316756, XrefRangeEnd = 316757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCPresenceAccessZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCPresenceAccessZone>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPresenceAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9D8 RID: 47576 RVA: 0x0005AD3B File Offset: 0x00058F3B
		public NPCPresenceAccessZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003950 RID: 14672
		// (get) Token: 0x0600B9D9 RID: 47577 RVA: 0x002E5928 File Offset: 0x002E3B28
		// (set) Token: 0x0600B9DA RID: 47578 RVA: 0x0005AD44 File Offset: 0x00058F44
		public unsafe static float CooldownTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCPresenceAccessZone.NativeFieldInfoPtr_CooldownTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCPresenceAccessZone.NativeFieldInfoPtr_CooldownTime, (void*)(&value));
			}
		}

		// Token: 0x17003951 RID: 14673
		// (get) Token: 0x0600B9DB RID: 47579 RVA: 0x002E5944 File Offset: 0x002E3B44
		// (set) Token: 0x0600B9DC RID: 47580 RVA: 0x0005AD52 File Offset: 0x00058F52
		public unsafe Collider DetectionZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_DetectionZone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_DetectionZone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003952 RID: 14674
		// (get) Token: 0x0600B9DD RID: 47581 RVA: 0x002E5974 File Offset: 0x002E3B74
		// (set) Token: 0x0600B9DE RID: 47582 RVA: 0x0005AD71 File Offset: 0x00058F71
		public unsafe NPC TargetNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_TargetNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_TargetNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003953 RID: 14675
		// (get) Token: 0x0600B9DF RID: 47583 RVA: 0x002E59A4 File Offset: 0x002E3BA4
		// (set) Token: 0x0600B9E0 RID: 47584 RVA: 0x0005AD90 File Offset: 0x00058F90
		public unsafe float timeSinceNPCSensed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_timeSinceNPCSensed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPresenceAccessZone.NativeFieldInfoPtr_timeSinceNPCSensed)) = value;
			}
		}

		// Token: 0x04007D59 RID: 32089
		private static readonly IntPtr NativeFieldInfoPtr_CooldownTime;

		// Token: 0x04007D5A RID: 32090
		private static readonly IntPtr NativeFieldInfoPtr_DetectionZone;

		// Token: 0x04007D5B RID: 32091
		private static readonly IntPtr NativeFieldInfoPtr_TargetNPC;

		// Token: 0x04007D5C RID: 32092
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceNPCSensed;

		// Token: 0x04007D5D RID: 32093
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007D5E RID: 32094
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04007D5F RID: 32095
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04007D60 RID: 32096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
