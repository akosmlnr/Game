using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000212 RID: 530
	public class TaskManager : Singleton<TaskManager>
	{
		// Token: 0x06002B98 RID: 11160 RVA: 0x000FD57C File Offset: 0x000FB77C
		// Note: this type is marked as 'beforefieldinit'.
		static TaskManager()
		{
			Il2CppClassPointerStore<TaskManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "TaskManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskManager>.NativeClassPtr);
			TaskManager.NativeFieldInfoPtr_currentTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, "currentTask");
			TaskManager.NativeFieldInfoPtr_TaskCompleteSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, "TaskCompleteSound");
			TaskManager.NativeFieldInfoPtr_OnTaskStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, "OnTaskStarted");
			TaskManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668221);
			TaskManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668222);
			TaskManager.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668223);
			TaskManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668224);
			TaskManager.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668225);
			TaskManager.NativeMethodInfoPtr_PlayTaskCompleteSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668226);
			TaskManager.NativeMethodInfoPtr_StartTask_Public_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668227);
			TaskManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668228);
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x000FD688 File Offset: 0x000FB888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124673, XrefRangeEnd = 124686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x000FD6C4 File Offset: 0x000FB8C4
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x000FD700 File Offset: 0x000FB900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124686, XrefRangeEnd = 124687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManager.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x000FD744 File Offset: 0x000FB944
		[CallerCount(0)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x000FD780 File Offset: 0x000FB980
		[CallerCount(0)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManager.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x000FD7BC File Offset: 0x000FB9BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 116063, RefRangeEnd = 116067, XrefRangeStart = 116063, XrefRangeEnd = 116067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayTaskCompleteSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManager.NativeMethodInfoPtr_PlayTaskCompleteSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x000FD7F0 File Offset: 0x000FB9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124687, XrefRangeEnd = 124688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTask(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManager.NativeMethodInfoPtr_StartTask_Public_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x000FD834 File Offset: 0x000FBA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124688, XrefRangeEnd = 124691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x00017898 File Offset: 0x00015A98
		public TaskManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06002BA2 RID: 11170 RVA: 0x000FD870 File Offset: 0x000FBA70
		// (set) Token: 0x06002BA3 RID: 11171 RVA: 0x000178A1 File Offset: 0x00015AA1
		public unsafe Task currentTask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManager.NativeFieldInfoPtr_currentTask);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManager.NativeFieldInfoPtr_currentTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x000FD8A0 File Offset: 0x000FBAA0
		// (set) Token: 0x06002BA5 RID: 11173 RVA: 0x000178C0 File Offset: 0x00015AC0
		public unsafe AudioSourceController TaskCompleteSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManager.NativeFieldInfoPtr_TaskCompleteSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManager.NativeFieldInfoPtr_TaskCompleteSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06002BA6 RID: 11174 RVA: 0x000FD8D0 File Offset: 0x000FBAD0
		// (set) Token: 0x06002BA7 RID: 11175 RVA: 0x000178DF File Offset: 0x00015ADF
		public unsafe Il2CppSystem.Action<Task> OnTaskStarted
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManager.NativeFieldInfoPtr_OnTaskStarted);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Task>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManager.NativeFieldInfoPtr_OnTaskStarted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CE6 RID: 7398
		private static readonly System.IntPtr NativeFieldInfoPtr_currentTask;

		// Token: 0x04001CE7 RID: 7399
		private static readonly System.IntPtr NativeFieldInfoPtr_TaskCompleteSound;

		// Token: 0x04001CE8 RID: 7400
		private static readonly System.IntPtr NativeFieldInfoPtr_OnTaskStarted;

		// Token: 0x04001CE9 RID: 7401
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001CEA RID: 7402
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04001CEB RID: 7403
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04001CEC RID: 7404
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001CED RID: 7405
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001CEE RID: 7406
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayTaskCompleteSound_Public_Void_0;

		// Token: 0x04001CEF RID: 7407
		private static readonly System.IntPtr NativeMethodInfoPtr_StartTask_Public_Void_Task_0;

		// Token: 0x04001CF0 RID: 7408
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
