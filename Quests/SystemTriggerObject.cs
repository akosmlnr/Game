using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001D7 RID: 471
	public class SystemTriggerObject : MonoBehaviour
	{
		// Token: 0x0600279A RID: 10138 RVA: 0x000EF878 File Offset: 0x000EDA78
		// Note: this type is marked as 'beforefieldinit'.
		static SystemTriggerObject()
		{
			Il2CppClassPointerStore<SystemTriggerObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "SystemTriggerObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemTriggerObject>.NativeClassPtr);
			SystemTriggerObject.NativeFieldInfoPtr_SystemTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTriggerObject>.NativeClassPtr, "SystemTrigger");
			SystemTriggerObject.NativeMethodInfoPtr_Trigger_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTriggerObject>.NativeClassPtr, 100667750);
			SystemTriggerObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTriggerObject>.NativeClassPtr, 100667751);
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x000EF8E4 File Offset: 0x000EDAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121041, XrefRangeEnd = 121043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTriggerObject.NativeMethodInfoPtr_Trigger_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x000EF918 File Offset: 0x000EDB18
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemTriggerObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemTriggerObject>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTriggerObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x00015D5D File Offset: 0x00013F5D
		public SystemTriggerObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x0600279E RID: 10142 RVA: 0x000EF954 File Offset: 0x000EDB54
		// (set) Token: 0x0600279F RID: 10143 RVA: 0x00015D66 File Offset: 0x00013F66
		public unsafe SystemTrigger SystemTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTriggerObject.NativeFieldInfoPtr_SystemTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SystemTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTriggerObject.NativeFieldInfoPtr_SystemTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A4C RID: 6732
		private static readonly IntPtr NativeFieldInfoPtr_SystemTrigger;

		// Token: 0x04001A4D RID: 6733
		private static readonly IntPtr NativeMethodInfoPtr_Trigger_Public_Void_0;

		// Token: 0x04001A4E RID: 6734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
